using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Feriado
    {
        private DateTime fecha;
        private string descripcion;
        public Feriado(DateTime fecha, string descripcion)
        {
            this.fecha = fecha;
            this.descripcion = descripcion;
        }


        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        public static explicit operator DateTime(Feriado feriado)
        {
            return feriado.Fecha;
        }

        public static bool operator ==(Feriado f1, Feriado f2)
        {
            return (f1.Fecha == f2.Fecha);
        }
        public static bool operator !=(Feriado f1, Feriado f2)
        {
            return !(f1 == f2);
        }
        public override string ToString()
        {
            return $"Fecha: {this.Fecha.ToString("dd/MM/yyyy")}, {this.Descripcion}"; 
        }
    }
}
