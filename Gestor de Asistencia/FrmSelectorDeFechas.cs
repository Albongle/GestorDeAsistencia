using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Asistencia
{
    public partial class FrmSelectorDeFechas : Form
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        public FrmSelectorDeFechas()
        {
            InitializeComponent();
            this.fechaInicio = this.dtmpFechaInicio.Value.Date;
            this.fechaFin = this.dtmpFechaFin.Value.Date;
        }

        public DateTime FechaInicio
        {
            get
            {
                return this.fechaInicio;
            }
        }
        public DateTime FechaFin
        {
            get
            {
                return this.fechaFin;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.fechaInicio = this.dtmpFechaInicio.Value.Date;
            this.fechaFin = this.dtmpFechaFin.Value.Date;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dtmpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            this.fechaInicio = this.dtmpFechaInicio.Value.Date;
        }

        private void dtmpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            this.fechaFin = this.dtmpFechaFin.Value.Date;
        }
    }
}
