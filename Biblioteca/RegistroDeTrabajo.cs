using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class RegistroDeTrabajo : ICloneable
    {
        static List<string> tipoNovedades;
        private Empleado empleado;
        private DateTime fechaTrabajada;
        private int cantidad;
        private string novedad;
        private ETurno turno;
        public enum ETurno {NA,AM,PM}

        static RegistroDeTrabajo()
        {
            RegistroDeTrabajo.tipoNovedades = new List<string> {"Presente","Turno Diagramado", "Feriado", "Franco", "Licencia", "Dia de Estudio", "Franco Compensatorio", "Ausente", "Vacaciones", "Enfermedad"};
        }
        public RegistroDeTrabajo(Empleado empleado, DateTime fechaTrabajada, string novedad, ETurno turno, int cantidad)
        {
            this.empleado = empleado;
            this.fechaTrabajada = fechaTrabajada;
            this.novedad = novedad;
            this.turno = turno;
            this.cantidad = cantidad;
        }

        public Empleado Empleado
        {
            get
            {
                return this.empleado;
            }
        }
        public DateTime FechaTrabajada
        {
            get
            {
                return this.fechaTrabajada;
            }
            set
            {
                this.fechaTrabajada = value;
            }
        }
        public string Novedad
        {
            get
            {
                return this.novedad;
            }
            set
            {
                if(this.ValidaNovedad(value))
                {
                    this.novedad = value;
                }
            }
        }
        public ETurno Turno
        {
            get
            {
                return this.turno;
            }
            set
            {
                this.turno= value;
            }
        }
        public static List<string> TiposDeNovedades
        {
            get
            {
                return tipoNovedades;
            }
        }
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                if(this.ValidaCantidad(value))
                {
                    this.cantidad = value;
                }
            }
        }
       
        public override string ToString()
        {
            return $"{this.Empleado.ToString()} - {this.FechaTrabajada.ToString("dd/MM/yyyy")} - {this.Novedad} - {this.Cantidad}";
        }

        public static bool operator == (RegistroDeTrabajo rt1, RegistroDeTrabajo rt2)
        {
            return (rt1.Empleado == rt2.Empleado) && (rt1.FechaTrabajada == rt2.FechaTrabajada);
        }
        public static bool operator !=(RegistroDeTrabajo rt1, RegistroDeTrabajo rt2)
        {
            return !(rt1 == rt2);
        }
        private bool ValidaCantidad (int cantidad)
        {
            bool returnAux = false;
            if(cantidad==1 || cantidad==3 || cantidad== 8)
            {
                returnAux = true;
            }

            return returnAux;
        }
        private bool ValidaNovedad(string novedad)
        {
            return RegistroDeTrabajo.TiposDeNovedades.Contains(novedad);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
