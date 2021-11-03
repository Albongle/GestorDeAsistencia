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
    public partial class FrmNovedadesEmpleado : Form
    {
        private List<RegistroDeTrabajo> registroDeTrabajos;
        private List<string> novedades;
        
        public FrmNovedadesEmpleado(List<RegistroDeTrabajo> registroDeTrabajos)
        {
            InitializeComponent();
            this.registroDeTrabajos = registroDeTrabajos;
        }

        private void FrmNovedadesEmpleado_Load(object sender, EventArgs e)
        {
            this.lstBoxNovovedades.DataSource = this.novedades;
            this.dtpFechaDeTrabajo.ValueChanged += lstBoxNovovedades_SelectedIndexChanged;
        }

        public List<string> Novedades
        {
            set
            {
                this.novedades = value;
            }
        }

        private void lstBoxNovovedades_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ImprimirRegistros();
        }

        private void ImprimirRegistros()
        {
            string stringAux = string.Empty;
            this.rchTextDatos.Text = string.Empty;
            IEnumerable<IGrouping<string, RegistroDeTrabajo>> lista = this.registroDeTrabajos.Where(x => x.Novedad == this.lstBoxNovovedades.SelectedItem.ToString() && x.FechaTrabajada == this.dtpFechaDeTrabajo.Value.Date).GroupBy(x => {
                return $"{x.FechaTrabajada.Date.ToString("dd/MM/yyyy")} - {x.Turno.ToString()}";
            });
            foreach (IGrouping<string, RegistroDeTrabajo> item in lista)
            {
                stringAux=$"{item.Count()} novedades de tipo:\"{this.lstBoxNovovedades.SelectedItem.ToString()}\" para el dia {item.Key}\n\n";

                foreach (RegistroDeTrabajo registro in item)
                {

                    stringAux += $"{registro.ToString()}\n";
                }
                this.rchTextDatos.Text+= $"{stringAux}\n";
            }
        }
    }
}
