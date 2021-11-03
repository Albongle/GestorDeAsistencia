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
    public partial class FrmGestorFeriados : Form
    {
        private List<Feriado> feriados;
        private FeriadosDAO feriadosDAO;
        private Feriado feriadoAux;
        public FrmGestorFeriados(List<Feriado> feriados)
        {
            InitializeComponent();
            this.feriados = feriados;
        }

        private void FrmGestorFeriados_Load(object sender, EventArgs e)
        {
            this.feriadosDAO = new FeriadosDAO(FrmGestorAsistencia.Ruta);
            this.feriadosDAO.EnviarMensaje += InformarMensajes;
            this.dgvFeriados.DataSource = this.Feriados;
            this.calendarioFeriados.BoldedDates = (this.Feriados.ConvertAll(feriado => { return (DateTime)feriado; })).ToArray();
            this.txtFechaSeleccionada.Text = this.calendarioFeriados.SelectionRange.Start.Date.ToString("dd/MM/yyyy");
            this.calendarioFeriados.DateChanged += calendarioFeriados_DateSelected;
        }

        public List<Feriado> Feriados
        {
            get
            {
                return this.feriados;
            }
            set
            {
                this.feriados = value;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.grpFeriado.Visible = false;
            if(this.txtFechaSeleccionada.Text!= "Seleccione un solo valor")
            {
                this.feriadoAux = new Feriado(this.calendarioFeriados.SelectionStart.Date, this.txtDescripcion.Text);
                this.feriadosDAO.InsertarFeriados(this.feriadoAux);
                this.Feriados = this.feriadosDAO.LeeDiasFeriadosDeLaBase();
                this.calendarioFeriados.BoldedDates = (this.Feriados.ConvertAll(feriado => { return (DateTime)feriado; })).ToArray();
                this.calendarioFeriados_DateSelected(sender, new DateRangeEventArgs(this.calendarioFeriados.SelectionStart, this.calendarioFeriados.SelectionEnd));
                this.txtDescripcion.Text = string.Empty;
            }
            else
            {
                this.InformarMensajes("Debe seleccionar una sola fecha","Alerta");
                this.txtDescripcion.Text = string.Empty;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.grpFeriado.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.grpFeriado.Visible = false;
            this.txtDescripcion.Text = string.Empty;
        }

        private void dgvFeriados_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvFeriados.SelectedRows)
            {
                this.feriadoAux = new Feriado((DateTime)item.Cells[0].Value, item.Cells[1].Value.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Se va a eliminar la siguiente fecha \n{this.feriadoAux.ToString()}\n¿Desea Continuar?","Feriado", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==  DialogResult.Yes)
            {
                this.feriadosDAO.BorraFeriado(this.feriadoAux);
                this.Feriados = this.feriadosDAO.LeeDiasFeriadosDeLaBase();
                this.calendarioFeriados.BoldedDates = (this.Feriados.ConvertAll(feriado => { return (DateTime)feriado; })).ToArray();
                this.calendarioFeriados_DateSelected(sender, new DateRangeEventArgs(this.calendarioFeriados.SelectionStart, this.calendarioFeriados.SelectionEnd));
            }
        }
        private void InformarMensajes(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje,titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calendarioFeriados_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.dgvFeriados.DataSource = this.feriados.FindAll(feriado => {
                return feriado.Fecha.Date >= this.calendarioFeriados.SelectionStart.Date && feriado.Fecha.Date <= this.calendarioFeriados.SelectionEnd.Date;
            });
            if ((this.calendarioFeriados.SelectionEnd.Date - this.calendarioFeriados.SelectionStart.Date).TotalDays > 0)
            {
                this.txtFechaSeleccionada.Text = "Seleccione un solo valor";
            }
            else
            {
                this.txtFechaSeleccionada.Text = this.calendarioFeriados.SelectionStart.Date.ToString("dd/MM/yyyy");
            }
        }
    }
}
