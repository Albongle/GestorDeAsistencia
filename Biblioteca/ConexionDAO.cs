using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class ConexionDAO
    {
        private string stringConexion;
        private OleDbConnection cadenaConexion;
        private string ruta;


        private  ConexionDAO()
        {
            this.stringConexion = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";
        }
        protected ConexionDAO(string ruta)
            :this()
        {
            this.RutaConexion = ruta;
            this.cadenaConexion = new OleDbConnection(this.RutaConexion);
            
        }

        public string RutaConexion
        {
            get
            {
                return this.ruta;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.ruta = this.stringConexion + value;
                }
            }
        }
        public bool PruebaConexion
        {
            get
            {
                bool returnAux = false ;
                if(this.Conector.State == System.Data.ConnectionState.Closed)
                {
                    try
                    {
                        this.Conector.Open();
                        this.Conector.Close();
                        returnAux = true;
                    }
                    catch (Exception)
                    {
                        returnAux = false;
                    }
                }
                return returnAux;
            }
        }
        protected OleDbConnection Conector
        {
            get
            {
                return this.cadenaConexion;
            }
        }
    }
}
