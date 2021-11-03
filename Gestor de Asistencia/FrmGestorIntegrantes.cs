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

namespace Gestor_de_Asistencia
{
    public partial class FrmGestorIntegrantes : Form
    {
        private EmpleadosDAO empleadosDAO;

        private bool flag;
        private string legajoSeleccionado;
        private List<Empleado> integrantes;
        private DataGridViewRow integranteSeleccionado;
        public FrmGestorIntegrantes(List<Empleado> integrantes)
        {
            InitializeComponent();
            this.integrantes = integrantes;
            empleadosDAO = new EmpleadosDAO(FrmGestorAsistencia.Ruta);
            empleadosDAO.EnviarMensaje += InformarMensajes;
        }

        public List<Empleado> Integrantes
        {
            get
            {
                return this.integrantes;
            }
            set
            {
                this.integrantes = value;
            }
        }

        private void FrmGestorIntegrantes_Load(object sender, EventArgs e)
        {
            for (DateTime i = new DateTime(0001, 1, 1, 0, 0, 0); i < new DateTime(0001, 1, 1, 23, 59, 59); i = i.AddHours(1))
            {
                this.cmbHoraInicio.Items.Add(i);
                this.cmbHoraFin.Items.Add(i);
            }
            this.cmbHoraInicio.FormatString = "HH:mm";
            this.cmbHoraFin.FormatString = "HH:mm";
            this.dgvIntegrantes.DataSource = this.Integrantes;
            this.btnAceptar.Click += dgvIntegrantes_SelectionChanged;
            this.btnEditar.Click+= dgvIntegrantes_SelectionChanged;
            this.btnCancelar.Click += dgvIntegrantes_SelectionChanged;
            this.grpBoxDatos.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.flag = false;
            this.LimpiarControles();
            this.grpBoxDatos.Enabled = true;
        }

        private void InformarMensajes(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvIntegrantes_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvIntegrantes.SelectedRows)
            {
                this.legajoSeleccionado= item.Cells[0].Value.ToString();
                this.txtLegajo.Text = item.Cells[0].Value.ToString();
                this.txtContrato.Text = item.Cells[1].Value.ToString();
                this.txtFuncion.Text= item.Cells[2].Value.ToString();
                this.cmbHoraInicio.SelectedIndex=((TimeSpan)item.Cells[3].Value).Hours;
                this.cmbHoraFin.SelectedIndex = ((TimeSpan)item.Cells[4].Value).Hours;
                this.txtApellido.Text=item.Cells[5].Value.ToString();
                this.txtNombre.Text=item.Cells[6].Value.ToString();
                this.dtpFechaDeNacimiento.Value = (DateTime)item.Cells[7].Value;
                this.txtDni.Text= item.Cells[8].Value.ToString();
                this.txtTelefono.Text=item.Cells[9].Value.ToString();
                this.integranteSeleccionado = item;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Empleado empleado;
            try
            {
                empleado = new Empleado(this.txtLegajo.Text, this.txtNombre.Text, this.txtApellido.Text, this.txtContrato.Text, this.dtpFechaDeNacimiento.Value.Date, this.txtDni.Text, this.txtTelefono.Text, this.txtFuncion.Text, ((DateTime)this.cmbHoraInicio.SelectedItem).TimeOfDay, ((DateTime)this.cmbHoraFin.SelectedItem).TimeOfDay);
                if (!this.flag)
                {
                    empleadosDAO.InsertarEmpleados(empleado);
                }
                else
                {
                    empleadosDAO.ModificarEmpleado(empleado, this.legajoSeleccionado);
                }
                this.Integrantes = empleadosDAO.LeeEmpleadosDeLaBase();
                this.dgvIntegrantes.DataSource = this.Integrantes;
                this.grpBoxDatos.Enabled = false;
            }
            catch (Exception ex)
            {
                this.InformarMensajes(ex.Message, ex.Source);
            }
            this.grpBoxDatos.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.flag = true;
            this.grpBoxDatos.Enabled = true;
        }
        private void LimpiarControles()
        {
            this.txtLegajo.Text = string.Empty;
            this.txtContrato.Text = string.Empty;
            this.txtFuncion.Text = string.Empty;
            this.cmbHoraInicio.SelectedIndex = 0;
            this.cmbHoraFin.SelectedIndex = 23;
            this.txtApellido.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.dtpFechaDeNacimiento.Value = DateTime.Now;
            this.txtDni.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Esta por eliminar el empleado con legajo \n{this.legajoSeleccionado}, ¿Desea continuar?","Eliminar", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                empleadosDAO.BorraEmpleado(this.legajoSeleccionado);
            }
            this.Integrantes = empleadosDAO.LeeEmpleadosDeLaBase();
            this.dgvIntegrantes.DataSource=this.Integrantes;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.grpBoxDatos.Enabled = false;
            this.flag = false;
        }
    }
}
