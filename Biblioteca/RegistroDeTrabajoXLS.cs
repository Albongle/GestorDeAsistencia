using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Biblioteca
{
    public class RegistroDeTrabajoXLS : ConexionDAO
    {
        private static string conexionStrFin= ";Extended Properties = 'Excel 12.0;'";
        private List<Empleado> empleados;
        public event Biblioteca.InformarMensajes EnviarMensaje;
        public RegistroDeTrabajoXLS(string rutaConexion):
            base(rutaConexion + RegistroDeTrabajoXLS.conexionStrFin)
        {
        }
        public List<Empleado> ListaEmpleados
        {
            set
            {
                this.empleados = value;
            }
        }

        public List<RegistroDeTrabajo> LeerArchivo()
        {
            List<RegistroDeTrabajo> registroDeTrabajos = null;
            RegistroDeTrabajo registroDeTrabajo;
            try
            {
                string sentencia = "SELECT * FROM [Novedades$]";
                OleDbCommand excelCommand = new OleDbCommand(sentencia, base.Conector);
                if (base.Conector.State == System.Data.ConnectionState.Closed)
                {
                    base.Conector.Open();
                }
                OleDbDataReader excelDataReader = excelCommand.ExecuteReader();
                registroDeTrabajos = new List<RegistroDeTrabajo>();
                while (excelDataReader.Read())
                {
                    if (object.ReferenceEquals(this.empleados, null))
                    {
                        registroDeTrabajo = new RegistroDeTrabajo(new Empleado(excelDataReader.GetString(0).ToLower(), excelDataReader.GetString(1), excelDataReader.GetString(2)),
                                            excelDataReader.GetDateTime(3),
                                            excelDataReader.GetString(4),
                                            (RegistroDeTrabajo.ETurno)((int)excelDataReader.GetDouble(5)),
                                            (int)excelDataReader.GetDouble(6));
                    }
                    else
                    {
                        registroDeTrabajo = new RegistroDeTrabajo(this.empleados.Find(x => x.Legajo == excelDataReader.GetString(0).ToLower()),
                                            excelDataReader.GetDateTime(3),
                                            excelDataReader.GetString(4),
                                            (RegistroDeTrabajo.ETurno)((int)excelDataReader.GetDouble(5)),
                                            (int)excelDataReader.GetDouble(6));
                    }

                    registroDeTrabajos.Add(registroDeTrabajo);
                }
            }
            catch (Exception ex)
            {
                this.EnviarMensaje.Invoke(ex.Message, ex.HelpLink);
            }
            finally
            {
                if (base.Conector != null && base.Conector.State == System.Data.ConnectionState.Open)
                {
                    base.Conector.Close();
                }
            }
            return registroDeTrabajos;
        }
    }
}
