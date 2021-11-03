using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Persona
    {
        #region "Atributos"
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private int dni;
        private string telefono;
        #endregion

        #region "Constructores"
        protected Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        #endregion

        #region "Atributos"
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (this.ValidaNombreApellido(value))
                {
                    this.apellido = value;
                }
                else
                {
                    throw new Exception("Apellido Erroneo");
                }
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (this.ValidaNombreApellido(value))
                {
                    this.nombre = value;
                }
                else
                {
                    throw new Exception("Nombre Erroneo");
                }
            }
        }
        public DateTime FechaDeNacimiento
        {
            get
            {
                return this.fechaDeNacimiento;
            }
            set
            {
                if (this.ValidaFecha(value, DateTime.Now))
                {
                    this.fechaDeNacimiento = value;
                }
                else
                {
                    throw new Exception("Fecha de Nacimiento Erronea");
                }

            }
        }
        public string Dni
        {
            get
            {
                return this.dni.ToString();
            }
            set
            {
                int auxDni = this.ValidaDni(value);
                if (auxDni > 0)
                {
                    this.dni = auxDni;
                }
                else
                {
                    throw new Exception("DNI Erroneo");
                }
            }
        }
        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                if (this.ValidaTelefono(value))
                {
                    this.telefono = value;
                }
                else
                {
                    throw new Exception("Numero de Telefono erroneo, el formato debe ser (011 o 0351)15-1111-1111");
                }
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo que valida el formato del Nombre y Apellido
        /// </summary>
        /// <param name="valor">Es la cadena de tecto a validar</param>
        /// <returns>True en caso de ser una cadena correcta, de lo contrario False</returns>
        private bool ValidaNombreApellido(string valor)
        {
            bool returnAux = false;
            if (!string.IsNullOrWhiteSpace(valor) && this.ValidaCadenaTexto(valor, new Regex(@"^[a-zA-Z]+$")))
            {
                returnAux = true;
            }
            return returnAux;
        }
        /// <summary>
        /// Metodo que la fecha de Fin no sea mayor a la de Inicio
        /// </summary>
        /// <param name="fechaInicio">Fecha de Inicio</param>
        /// <param name="fechaFin">Fecha de Fin</param>
        /// <returns>True en caso correcto, de lo contrario False</returns>
        protected bool ValidaFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            bool returnAux = false;
            if (fechaFin > fechaInicio)
            {
                returnAux = true;
            }
            return returnAux;
        }

        /// <summary>
        /// Metodo que valida que la cadena recibida sea un DNI y la convierte a INT
        /// </summary>
        /// <param name="valor">Es la cadena a evaluar</param>
        /// <returns>Un numero de DNI, 0 en caso de ser vacia o con un carracter erroneo, -1 si no pudoi convertir a INT</returns>
        private int ValidaDni(string valor)
        {
            int returnAux = 0;
            if (!string.IsNullOrWhiteSpace(valor) && this.ValidaCadenaTexto(valor, new Regex(@"^[0-9]{1,8}$")))
            {
                if (!int.TryParse(valor, out returnAux))
                {
                    returnAux = -1;
                }
            }
            return returnAux;
        }
        /// <summary>
        /// Matodo que valida que la cadena recibida sea un numero telefonico en un formato especifico (011 o 0351)15-1111-1111")
        /// </summary>
        /// <param name="valor">Es la cadena a evaluar</param>
        /// <returns>True en caso correcto, de lo contrario False</returns>
        private bool ValidaTelefono(string valor)
        {
            bool returnAux = false;
            if (!string.IsNullOrWhiteSpace(valor) && this.ValidaCadenaTexto(valor, new Regex(@"\([0-9]{3,4}\)[0-9]{2}\-[0-9]{4}\-[0-9]{3,4}")))
            {
                returnAux = true;
            }
            return returnAux;
        }

        /// <summary>
        /// Metodo utilizado para validar cadenas de Texto con Expresiones regulares
        /// </summary>
        /// <param name="valor">Es la cadena de Texto</param>
        /// <param name="expresion">Es la Expresion regular con la que se desea hacer Match</param>
        /// <returns>True en caso correcto, de lo contrario False</returns>
        protected bool ValidaCadenaTexto(string valor, Regex expresion)
        {
            return expresion.IsMatch(valor);
        }
        public virtual string MostrarDatos()
        {
            return $"{this.Apellido}, {this.Nombre}" +
                $"\nDNI: {this.Dni}" +
                $"\nTelefono: {this.Telefono}" +
                $"\nFecha de Nacimiento: {this.FechaDeNacimiento.ToString("dd/MM/yyyy")}";        
        }
        public abstract override string ToString();
        #endregion
    }
}
