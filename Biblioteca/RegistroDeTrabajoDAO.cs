using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class RegistroDeTrabajoDAO : ConexionDAO
    {
        private List<Empleado> empleados;
        public event Biblioteca.InformarMensajes EnviarMensaje;
        public RegistroDeTrabajoDAO(string ruta)
            : base(ruta)
        {
        }

        public List<Empleado> ListaEmpleados
        {
            set
            {
                this.empleados = value;
            }
        }
        public List<RegistroDeTrabajo> LeeRegistroDeTrabajo()
        {
            List<RegistroDeTrabajo> registroDeTrabajos = null;
            RegistroDeTrabajo registroDeTrabajo;
            try
            {
                string sentencia = "SELECT * FROM [T04-REGISTRO DE TRABAJO]";
                OleDbCommand accessCommand = new OleDbCommand(sentencia, base.Conector);
                if (base.Conector.State == System.Data.ConnectionState.Closed)
                {
                    base.Conector.Open();
                }
                OleDbDataReader accessDataReader = accessCommand.ExecuteReader();
                registroDeTrabajos = new List<RegistroDeTrabajo>();

                while (accessDataReader.Read())
                {
                    if (object.ReferenceEquals(this.empleados, null))
                    {
                        registroDeTrabajo = new RegistroDeTrabajo(new Empleado(accessDataReader.GetString(0), accessDataReader.GetString(1), accessDataReader.GetString(2)),
                                            accessDataReader.GetDateTime(3),
                                            accessDataReader.GetString(4),
                                            (RegistroDeTrabajo.ETurno)accessDataReader.GetInt16(5),
                                            accessDataReader.GetInt16(6));
                    }
                    else
                    {
                        registroDeTrabajo = new RegistroDeTrabajo(this.empleados.Find(x => x.Legajo == accessDataReader.GetString(0)),
                                            accessDataReader.GetDateTime(3),
                                            accessDataReader.GetString(4),
                                            (RegistroDeTrabajo.ETurno)accessDataReader.GetInt16(5),
                                            accessDataReader.GetInt16(6));
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

        public bool BorraRegistroDeTrabajo(Empleado empleado, DateTime fecha)
        {
            bool returnAux = false;
            try
            {
                string sentencia = "DELETE FROM [T04-REGISTRO DE TRABAJO] where Legajo=@legajo AND Fecha = @fecha";
                OleDbCommand accessCommand = new OleDbCommand(sentencia, base.Conector);
                accessCommand.Parameters.AddWithValue("legajo", empleado.Legajo);
                accessCommand.Parameters.AddWithValue("fecha", fecha.Date);
                if (base.Conector.State == System.Data.ConnectionState.Closed)
                {
                    base.Conector.Open();
                }
                accessCommand.ExecuteNonQuery();
                returnAux = true;
            }
            catch (Exception ex)
            {
                this.EnviarMensaje.Invoke(ex.Message,ex.HelpLink);
            }
            finally
            {
                if (base.Conector != null && base.Conector.State == System.Data.ConnectionState.Open)
                {
                    base.Conector.Close();
                }
            }
            return returnAux;
        }
        public void BorraRegistroDeTrabajo(DateTime fecha)
        {
            try
            {
                string sentencia = "DELETE FROM [T04-REGISTRO DE TRABAJO] where Fecha = @fecha";
                OleDbCommand accessCommand = new OleDbCommand(sentencia, base.Conector);
                accessCommand.Parameters.AddWithValue("fecha", fecha.Date);
                if (base.Conector.State == System.Data.ConnectionState.Closed)
                {
                    base.Conector.Open();
                }
                accessCommand.ExecuteNonQuery();
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
        }
        public bool AgregarRegistroDeTrabajo(RegistroDeTrabajo registroDeTrabajo)
        {
            bool returnAux = false;
            try
            {
                string sentencia = "INSERT INTO [T04-REGISTRO DE TRABAJO] (Legajo,Nombre,Apellido,Fecha,Novedad,Turno,Cantidad) VALUES (@Legajo,@Nombre,@Apellido,@Fecha,@Novedad,@Turno,@Cantidad)";
                OleDbCommand accessCommand = new OleDbCommand(sentencia, base.Conector);
                accessCommand.Parameters.AddWithValue("Legajo", registroDeTrabajo.Empleado.Legajo);
                accessCommand.Parameters.AddWithValue("Nombre", registroDeTrabajo.Empleado.Nombre);
                accessCommand.Parameters.AddWithValue("Apellido", registroDeTrabajo.Empleado.Apellido);
                accessCommand.Parameters.AddWithValue("Fecha", registroDeTrabajo.FechaTrabajada);
                accessCommand.Parameters.AddWithValue("Novedad", registroDeTrabajo.Novedad);
                accessCommand.Parameters.AddWithValue("Turno", (int)registroDeTrabajo.Turno);
                accessCommand.Parameters.AddWithValue("Cantidad", registroDeTrabajo.Cantidad);
                if (base.Conector.State == System.Data.ConnectionState.Closed)
                {
                    base.Conector.Open();
                }
                accessCommand.ExecuteNonQuery();
                returnAux = true;
            }
            catch (Exception ex)
            {
                this.EnviarMensaje.Invoke(ex.Message,ex.HelpLink);
            }
            finally
            {
                if (base.Conector != null && base.Conector.State == System.Data.ConnectionState.Open)
                {
                    base.Conector.Close();
                }
            }
            return returnAux;
        }
    }
}
