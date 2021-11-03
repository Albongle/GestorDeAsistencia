using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using System.Configuration;
using System.Threading;

namespace Gestor_de_Asistencia
{
    public partial class FrmGestorAsistencia : Form
    {
        private List<RegistroDeTrabajo> registroDeTrabajos;
        private List<RegistroDeTrabajo> registroDeTrabajosSeleccionados;
        private FeriadosDAO feriadosDAO;
        private EmpleadosDAO empleadosDAO;
        private RegistroDeTrabajoDAO registroDeTrabajoDAO;
        private static string ruta;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private Empleado empleadoSeleccionado;
        private string novedadSeleccionada;
        private FrmGestorIntegrantes frmGestorIntegrantes;
        private FrmGestorFeriados frmGestorFeriados;
        private bool flagConexion;
        private Thread hiloImportacion;

        public FrmGestorAsistencia()
        {
            InitializeComponent();
        }

        public static string Ruta
        {
            get
            {
                return ruta;
            }
        }
        public List<RegistroDeTrabajo> RegistroDeTrabajos
        {
            get
            {
                return this.registroDeTrabajos;
            }
        }

        private void FrmGestorAsistencia_Load(object sender, EventArgs e)
        {
            this.MostrarControles(false);
            this.registroDeTrabajos = new List<RegistroDeTrabajo>();
            this.registroDeTrabajosSeleccionados = new List<RegistroDeTrabajo>();
            this.fechaInicio = this.calendario.SelectionStart;
            this.fechaFin = this.calendario.SelectionEnd;
            this.calendario.DateChanged += calendario_DateSelected;
            this.barraEstadoProgreso.Minimum = 0;
 
        }

        private void InformarMensajes(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FiltraListBox(Empleado empleado, DateTime fechaInicio, DateTime fechaFin)
        {

            this.dgvRegistroDeTrabajo.DataSource = this.registroDeTrabajos.Where(registroDeTrabajo =>
            {
                return registroDeTrabajo.FechaTrabajada >= fechaInicio && registroDeTrabajo.FechaTrabajada <= fechaFin && empleado == registroDeTrabajo.Empleado && registroDeTrabajo.Novedad != "Horas Nocturnas";
            }).ToList();

        }

        private void EliminarRegistrosDeTrabajo(List<RegistroDeTrabajo> objetosSeleccionados)
        {
            int cont = 0;
            foreach (RegistroDeTrabajo registroDeTrabajo in objetosSeleccionados)
            {                
                if (!this.registroDeTrabajoDAO.BorraRegistroDeTrabajo(registroDeTrabajo.Empleado, registroDeTrabajo.FechaTrabajada))
                {
                    MessageBox.Show($"{registroDeTrabajo.Empleado}\n{registroDeTrabajo.FechaTrabajada.ToString("dd/MM/yyyy")} - {registroDeTrabajo.Novedad}\nCantidad: {registroDeTrabajo.Cantidad}", "No se Elimino el Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cont++;
                    this.ActualizaBarraEstado($"Borrando Registros: {cont}/{objetosSeleccionados.Count}", true, cont);
                }
            }
            this.ActualizaBarraEstado("Finalizado", false, cont);
            this.ActualizaRegistrosDelaBase();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!this.flagConexion)
            {
                this.barraEstadoProgreso.Maximum = this.registroDeTrabajosSeleccionados.Count;
                Thread hilo = new Thread(new ParameterizedThreadStart(SuprimeRegistrosDeLabase));
                hilo.Start(this.registroDeTrabajosSeleccionados);
            }
        }

        private void cmbTipoNovedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoTurno.Items.Count > 0)
            {
                this.cmbTipoTurno.Items.Clear();
            }
            this.novedadSeleccionada = this.cmbTipoNovedad.SelectedItem.ToString();
            this.nUpDownCantidad.Enabled = false;
            this.nUpDownCantidad.Value = 1;
            this.cmbTipoTurno.Items.Add(RegistroDeTrabajo.ETurno.AM);
            this.cmbTipoTurno.Items.Add(RegistroDeTrabajo.ETurno.PM);

            if (this.novedadSeleccionada == "Turno Diagramado" || this.novedadSeleccionada == "Feriado")
            {
                this.nUpDownCantidad.Enabled = true;
            }
            else if (this.novedadSeleccionada != "Presente")
            {
                this.cmbTipoTurno.Items.Clear();
                this.cmbTipoTurno.Items.Add(RegistroDeTrabajo.ETurno.NA);
            }
            this.cmbTipoTurno.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!this.flagConexion)
            {
                this.AgregaRegistrosDeTrabajoSeleccionado(this.calendario.SelectionRange);
                this.ActualizaRegistrosDelaBase();
                this.FiltraListBox(this.empleadoSeleccionado, this.fechaInicio, this.fechaFin);
            }
        }
        private void AgregaRegistrosDeTrabajoSeleccionado(SelectionRange selectionRange)
        {

            for (DateTime i = selectionRange.Start; i <= selectionRange.End; i = i.AddDays(1))
            {
                RegistroDeTrabajo registroDeTrabajo = new RegistroDeTrabajo(this.empleadoSeleccionado, i, this.novedadSeleccionada, (RegistroDeTrabajo.ETurno)this.cmbTipoTurno.SelectedItem, (int)this.nUpDownCantidad.Value);
                if (!this.ValidacionDeNovedades(registroDeTrabajo, i.Date))
                {
                    this.InformarMensajes($"La fecha {registroDeTrabajo.FechaTrabajada.ToString("dd/MM/yyyy")}\nno corresponde con el tipo de novedad elegida", "Error Novedad");
                    continue;
                }
                if (this.ValidaRegistroDeTrabajoExistente(registroDeTrabajo))
                {
                    this.InformarMensajes($"El empleado {registroDeTrabajo.Empleado}\nposee registros para la fecha: {registroDeTrabajo.FechaTrabajada.ToString("dd/MM/yyyy")}", "Registro Existente");
                }
                else if (registroDeTrabajo.Novedad == "Presente" && registroDeTrabajo.Turno == RegistroDeTrabajo.ETurno.PM)
                {
                    this.registroDeTrabajoDAO.AgregarRegistroDeTrabajo(registroDeTrabajo);
                    if ((this.empleadoSeleccionado.HoraFin - new TimeSpan(20, 0, 0)).Hours > 0)
                    {
                        RegistroDeTrabajo registroHoras = new RegistroDeTrabajo(this.empleadoSeleccionado, i, "Horas Nocturnas", (RegistroDeTrabajo.ETurno)this.cmbTipoTurno.SelectedItem, (this.empleadoSeleccionado.HoraFin - new TimeSpan(20, 0, 0)).Hours);
                        this.registroDeTrabajoDAO.AgregarRegistroDeTrabajo(registroHoras);
                    }
                }
                else if (!this.registroDeTrabajoDAO.AgregarRegistroDeTrabajo(registroDeTrabajo))
                {
                    this.InformarMensajes($"{registroDeTrabajo.Empleado}\n{registroDeTrabajo.FechaTrabajada.ToString("dd/MM/yyyy")} - {registroDeTrabajo.Novedad}\nCantidad: {registroDeTrabajo.Cantidad}", "No se Agrego el Registro");
                }
            }
        }
        private bool ValidaRegistroDeTrabajoExistente(RegistroDeTrabajo registroDeTrabajo)
        {
            return this.RegistroDeTrabajos.Any(x => x == registroDeTrabajo);
        }
        private bool ValidaFeriados(DateTime fecha)
        {
            return this.frmGestorFeriados.Feriados.Any(x => x.Fecha == fecha);
        }
        private bool ValidaTurnosDiagramados(DateTime fecha)
        {
            bool returnAux;
            string dia = fecha.ToString("dddd");
            switch (dia)
            {
                case "sábado":
                case "domingo":
                    {
                        returnAux = true;
                        break;
                    }
                default:
                    {
                        returnAux = false;
                        break;
                    }
            }
            return returnAux;
        }

        private bool ValidacionDeNovedades(RegistroDeTrabajo registroDeTrabajo, DateTime fecha)
        {
            bool cargaFeriados = this.ValidaFeriados(fecha);
            bool turnosDiagramados = this.ValidaTurnosDiagramados(fecha);
            bool returnAux = false;
            switch (registroDeTrabajo.Novedad)
            {
                case "Turno Diagramado":
                    {
                        if (turnosDiagramados)
                        {
                            returnAux = true;
                        }
                        break;
                    }
                case "Feriado":
                    {
                        if (cargaFeriados)
                        {
                            returnAux = true;
                        }
                        break;
                    }
                case "Presente":
                    {
                        if (!turnosDiagramados && !cargaFeriados)
                        {
                            returnAux = true;
                        }
                        break;
                    }
                default:
                    {
                        returnAux = true;
                        break;
                    }
            }
            return returnAux;
        }


        private void lstBoxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.empleadoSeleccionado = (Empleado)this.lstBoxEmpleados.SelectedItem;
            this.FiltraListBox(this.empleadoSeleccionado, this.fechaInicio, this.fechaFin);
        }

        private void dgvRegistroDeTrabajo_SelectionChanged(object sender, EventArgs e)
        {
            if (this.registroDeTrabajosSeleccionados.Count > 0)
            {
                this.registroDeTrabajosSeleccionados.Clear();
            }


            foreach (DataGridViewRow item in this.dgvRegistroDeTrabajo.SelectedRows)
            {
                RegistroDeTrabajo registroDeTrabajoAux = new RegistroDeTrabajo((Empleado)item.Cells[0].Value, (DateTime)item.Cells[1].Value, (string)item.Cells[2].Value, (RegistroDeTrabajo.ETurno)item.Cells[3].Value, (int)item.Cells[4].Value);
                this.registroDeTrabajosSeleccionados.Add(registroDeTrabajoAux);
            }
        }

        private void btnIntegrantes_Click(object sender, EventArgs e)
        {
            if (!object.ReferenceEquals(this.frmGestorIntegrantes, null))
            {
                this.frmGestorIntegrantes.ShowDialog();
            }
            else
            {
                this.InformarMensajes("Debe establecer una conexion a la base de datos", "Alerta");
            }

        }
        private void ActualizaEmpleados(object sender, EventArgs e)
        {
            this.lstBoxEmpleados.DataSource = this.frmGestorIntegrantes.Integrantes;
        }

        private void ActualizaFeriados(object sender, EventArgs e)
        {
            if (!object.ReferenceEquals(this.frmGestorFeriados.Feriados, null))
            {
                this.calendario.BoldedDates = (this.frmGestorFeriados.Feriados.ConvertAll(feriado => { return (DateTime)feriado; })).ToArray();
            }
        }

        private void ActualizaRegistrosDelaBase()
        {
            if (!object.ReferenceEquals(this.registroDeTrabajoDAO, null))
            {
                this.registroDeTrabajoDAO.ListaEmpleados = (List<Empleado>)this.lstBoxEmpleados.DataSource;
                this.registroDeTrabajos = this.registroDeTrabajoDAO.LeeRegistroDeTrabajo();
            }
            else
            {
                this.InformarMensajes("Debe establecer una conexion a la base de datos", "Alerta");
            }

        }

        private void btnFeriados_Click(object sender, EventArgs e)
        {
            if (!object.ReferenceEquals(this.frmGestorFeriados, null))
            {
                this.frmGestorFeriados.ShowDialog();
            }
            else
            {
                this.InformarMensajes("Debe establecer una conexion a la base de datos", "Alerta");
            }
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            
            this.fechaInicio = this.calendario.SelectionStart;
            this.fechaFin = this.calendario.SelectionEnd;
            this.FiltraListBox(this.empleadoSeleccionado, this.fechaInicio, this.fechaFin);
        }
        private string ObtieneRutaConexion(string filter, string title)
        {
            string returnAux = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.Title = title;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                returnAux = openFileDialog.FileName;
            }
            else
            {
                throw new Exception($"No se pudo {title}");
            }
            return returnAux;
        }

        private void MostrarControles(bool estado)
        {
            foreach (Control item in this.Controls)
            {
                if (item.Name != "menuConexion")
                {
                    item.Visible = estado;
                }
            }
        }

        private void conectarConBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGestorAsistencia.ruta = this.ObtieneRutaConexion("accdb files (*.accdb)|*.accdb", "Conectar con Base de Datos");
            }
            catch (Exception ex)
            {
                this.InformarMensajes(ex.Message, ex.HelpLink);
                this.flagConexion = true;
            }

            this.registroDeTrabajoDAO = new RegistroDeTrabajoDAO(ruta);
            this.feriadosDAO = new FeriadosDAO(ruta);
            this.empleadosDAO = new EmpleadosDAO(ruta);

            if (this.registroDeTrabajoDAO.PruebaConexion && this.empleadosDAO.PruebaConexion && this.feriadosDAO.PruebaConexion)
            {
                //Eventos
                this.feriadosDAO.EnviarMensaje += InformarMensajes;
                this.empleadosDAO.EnviarMensaje += InformarMensajes;
                this.registroDeTrabajoDAO.EnviarMensaje += InformarMensajes;
                this.frmGestorIntegrantes = new FrmGestorIntegrantes(this.empleadosDAO.LeeEmpleadosDeLaBase());
                this.frmGestorIntegrantes.FormClosing += ActualizaEmpleados;
                this.frmGestorFeriados = new FrmGestorFeriados(this.feriadosDAO.LeeDiasFeriadosDeLaBase());
                this.frmGestorFeriados.FormClosing += ActualizaFeriados;
                this.ActualizaEmpleados(sender, e);
                //Marco en negrita los feriados en el calendiario
                this.ActualizaFeriados(sender, e);
                this.cmbTipoNovedad.DataSource = RegistroDeTrabajo.TiposDeNovedades;
                //Registro de trabajo
                this.ActualizaRegistrosDelaBase();
                this.flagConexion = false;
                this.MostrarControles(true);
                this.menuConexion.Enabled = false;
            }
            else
            {
                this.InformarMensajes("No se pudo establecer conexion con la base seleccionada", "Alerta");
            }
        }

        private void btnNovedadesPorDia_Click(object sender, EventArgs e)
        {
            FrmNovedadesEmpleado frmNovedadesEmpleado = new FrmNovedadesEmpleado(this.registroDeTrabajos);
            frmNovedadesEmpleado.Novedades = (List<String>)this.cmbTipoNovedad.DataSource;
            frmNovedadesEmpleado.ShowDialog();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroDeTrabajoXLS planaArchivo = new RegistroDeTrabajoXLS(this.ObtieneRutaConexion("Excel files (*.xlsm)|*.xlsm|Excel files (*.xlsx)|*.xlsx", "Conectar con Excel"));
                planaArchivo.EnviarMensaje += InformarMensajes;
                planaArchivo.ListaEmpleados = (List<Empleado>)this.lstBoxEmpleados.DataSource;
                List<RegistroDeTrabajo> registros = planaArchivo.LeerArchivo();

                if (VerificaRegistrosExistentesEnBase(ref registros))
                {
                    this.barraEstadoProgreso.Maximum = registros.Count;
                    this.hiloImportacion = new Thread(new ParameterizedThreadStart(ImportaRegistrosABase));
                    this.hiloImportacion.Start(registros);
                }
            }
            catch (Exception ex)
            {
                this.InformarMensajes(ex.Message, ex.HelpLink);
            }
        }

        private bool VerificaRegistrosExistentesEnBase(ref List<RegistroDeTrabajo> registrosBase)
        {
            if (this.RegistroDeTrabajos.Count > 0 && registrosBase.All(x =>
            {
                if (this.RegistroDeTrabajos.Any(z => z == x))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }))
            {
                throw new Exception("Registros ya contenidos en Base");
            }
            else
            {
                registrosBase = registrosBase.FindAll(x => !this.RegistroDeTrabajos.Exists(z => z == x));
                return true;
            }
        }
        private void ImportaRegistrosABase(object registros)
        {
            int cont = 0;
            int cantidad = ((List<RegistroDeTrabajo>)registros).Count;
            foreach (RegistroDeTrabajo rt in ((List<RegistroDeTrabajo>)registros))
            {
                cont++;
                this.ActualizaBarraEstado($"Cargando Novedades {cont}/{cantidad}", true, cont);
                if (rt.Novedad == "Presente" && rt.Turno == RegistroDeTrabajo.ETurno.PM)
                {
                    if ((rt.Empleado.HoraFin - new TimeSpan(20, 0, 0)).Hours > 0)
                    {
                        RegistroDeTrabajo registroHoras = new RegistroDeTrabajo(rt.Empleado, rt.FechaTrabajada, "Horas Nocturnas", rt.Turno, (rt.Empleado.HoraFin - new TimeSpan(20, 0, 0)).Hours);
                        this.registroDeTrabajoDAO.AgregarRegistroDeTrabajo(registroHoras);
                    }
                }
                this.registroDeTrabajoDAO.AgregarRegistroDeTrabajo(rt);
            }
            this.ActualizaBarraEstado("Finalizado", false, cont);
            this.ActualizaRegistrosDelaBase();
        }

        delegate void Callback(string mensaje, bool estado, int valor);
        private void ActualizaBarraEstado(string mensaje, bool estado, int valor)
        {
            if (this.InvokeRequired)
            {
                Callback callback = new Callback(ActualizaBarraEstado);
                object[] objs = new object[] { mensaje, estado, valor };
                this.Invoke(callback, objs);
            }
            else
            {
                if (valor == 1 || valor == this.barraEstadoProgreso.Maximum)
                {
                    this.barraEstadoProgreso.Visible = estado;
                    this.btnAgregar.Enabled = !estado;
                }
                this.barraEstadoTexto.Text = mensaje;
                this.barraEstadoProgreso.Value = valor;
            }
        }

        private void FrmGestorAsistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!object.ReferenceEquals(this.hiloImportacion, null) && this.hiloImportacion.IsAlive)
            {
                this.hiloImportacion.Abort();
            }
        }

        private void btnBorrarNovedades_Click(object sender, EventArgs e)
        {
            FrmSelectorDeFechas frmSelectorDeFechas = new FrmSelectorDeFechas();
            DialogResult resultado=frmSelectorDeFechas.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                int cantidaRegistros = (this.registroDeTrabajos.Where(x => x.FechaTrabajada >= frmSelectorDeFechas.FechaInicio && x.FechaTrabajada <= frmSelectorDeFechas.FechaFin)).ToList().Count; // cantidad de registros a borrar
                if (cantidaRegistros > 0)
                {
                    List<RegistroDeTrabajo>listaABorrar = (this.registroDeTrabajos.Where(x => x.FechaTrabajada >= frmSelectorDeFechas.FechaInicio && x.FechaTrabajada <= frmSelectorDeFechas.FechaFin)).ToList();
                    this.barraEstadoProgreso.Maximum = listaABorrar.Count;
                    Thread hilo = new Thread(new ParameterizedThreadStart(SuprimeRegistrosDeLabase));
                    hilo.Start(listaABorrar);
                }
                else
                {
                    this.InformarMensajes($"Sin registros que cumplan el siguiente criterio\nFecha de inicio: {frmSelectorDeFechas.FechaInicio.ToString("dd/MM/yyyy")} Fecha de fin: {frmSelectorDeFechas.FechaFin.ToString("dd/MM/yyyy")}", "Error");
                }
            }
        }

        private void SuprimeRegistrosDeLabase(object datos)
        {
            List<RegistroDeTrabajo> listaABorrar = (List<RegistroDeTrabajo>)datos;
            if(listaABorrar.Count>0)
            {
                fechaInicio = listaABorrar.Min(x => x.FechaTrabajada);
                fechaFin = listaABorrar.Max(x => x.FechaTrabajada);
                DialogResult resultado = MessageBox.Show($"Se van a borrar los resgistros de la base desde:\t\n{fechaInicio.ToString("dd/MM/yyyy")} hasta {fechaFin.ToString("dd/MM/yyyy")}\n¿Desea Continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    this.EliminarRegistrosDeTrabajo(listaABorrar);
                }
            }
        }
    }
}
