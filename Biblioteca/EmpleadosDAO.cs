using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public delegate void InformarMensajes(string mensaje, string titulo);

    public sealed class EmpleadosDAO: ConexionDAO
    {
        public event InformarMensajes EnviarMensaje;
        public EmpleadosDAO(string rutaConexion)
            :base(rutaConexion)
        {

        }
        public List<Empleado> LeeEmpleadosDeLaBase()
        {
            List<Empleado> empleados= null;
            try
            {
                string sentencia = "SELECT * FROM [T02-INTEGRANTES]";
                OleDbCommand accessCommand = new OleDbCommand(sentencia, base.Conector);
                if (base.Conector.State == System.Data.ConnectionState.Closed)
                {
                    base.Conector.Open();
                }
                OleDbDataReader accessDataReader = accessCommand.ExecuteReader();
                empleados = new List<Empleado>();
                while (accessDataReader.Read())
                {
                    Empleado empleado = new Empleado(
                        accessDataReader.GetString(0),//Legajo 
                        accessDataReader.GetString(3),//Nombre
                        accessDataReader.GetString(2), //Apellido
                        accessDataReader.GetString(1),//Contrato
                        accessDataReader.GetDateTime(5),//fecha de nacimiento 
                        accessDataReader.GetString(6),//dni
                        accessDataReader.GetString(4),//telefono 
                        accessDataReader.GetString(7),//funcion
                        accessDataReader.GetDateTime(8).TimeOfDay,//h inicio 
                        accessDataReader.GetDateTime(9).TimeOfDay//h fin
                        );
                    empleados.Add(empleado);
                }
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
            return empleados;
        }

        public void InsertarEmpleados (Empleado empleado)
        {
            try
            {
                string sentencia = "INSERT INTO [T02-INTEGRANTES] (Legajo,Contrato,Apellido,Nombre,Celular,[Fecha de nacimiento],DNI,Función,[H Inicio],[H Fin]) " +
                    "VALUES (@Legajo,@Contrato,@Apellido,@Nombre,@Celular,@Fechanac,@dni,@Funcion,@HInicio,@HFin)";
                OleDbCommand accessCommand = new OleDbCommand(sentencia, base.Conector);
                accessCommand.Parameters.AddWithValue("Legajo", empleado.Legajo); 
                accessCommand.Parameters.AddWithValue("Contrato",empleado.Contrato);
                accessCommand.Parameters.AddWithValue("Apellido", empleado.Apellido);
                accessCommand.Parameters.AddWithValue("Nombre", empleado.Nombre);
                accessCommand.Parameters.AddWithValue("Celular", empleado.Telefono);
                accessCommand.Parameters.AddWithValue("Fechanac",empleado.FechaDeNacimiento);
                accessCommand.Parameters.AddWithValue("dni", empleado.Dni);
                accessCommand.Parameters.AddWithValue("Funcion", empleado.Funcion);
                accessCommand.Parameters.AddWithValue("HInicio", empleado.HoraInicio);
                accessCommand.Parameters.AddWithValue("HFin", empleado.HoraFin);
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
        public void ModificarEmpleado (Empleado empleado, string legajo)
        {
            DateTime dateTimeAux = new DateTime(empleado.HoraInicio.Ticks);
            try
            {
                string sentencia = "UPDATE [T02-INTEGRANTES] SET " +
                    "[Legajo]=@leg, " +
                    "[Contrato]=@contrato, " +
                    "[Apellido]=@apellido, " +
                    "[Nombre]=@nombre, " +
                    "[Celular]=@celular, " +
                    "[Fecha de nacimiento]=@fechanac, " +
                    "[DNI]=@dni, " +
                    "[Función]=@funcion, " +
                    "[H INICIO]=@hinicio, " +
                    "[H FIN]=@hfin " +
                    $"WHERE [T02-INTEGRANTES].[Legajo]=\'{legajo}\'";
                OleDbCommand accessCommand = new OleDbCommand(sentencia, base.Conector);
                accessCommand.Parameters.AddWithValue("leg",empleado.Legajo);
                accessCommand.Parameters.AddWithValue("contrato",empleado.Contrato);
                accessCommand.Parameters.AddWithValue("apellido",empleado.Apellido);
                accessCommand.Parameters.AddWithValue("nombre",empleado.Nombre);
                accessCommand.Parameters.AddWithValue("celular",empleado.Telefono);
                accessCommand.Parameters.AddWithValue("fechanac",empleado.FechaDeNacimiento);
                accessCommand.Parameters.AddWithValue("dni",empleado.Dni);
                accessCommand.Parameters.AddWithValue("funcion",empleado.Funcion);
                accessCommand.Parameters.AddWithValue("hinicio",empleado.HoraInicio);
                accessCommand.Parameters.AddWithValue("hfin",empleado.HoraFin);
                if (base.Conector.State == System.Data.ConnectionState.Closed)
                {
                    base.Conector.Open();
                }
                int filasAfectadas=accessCommand.ExecuteNonQuery();
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
        public void BorraEmpleado(string legajo)
        {
            try
            {
                string sentencia = "DELETE FROM [T02-INTEGRANTES] WHERE [T02-INTEGRANTES].[Legajo]=@leg";
                OleDbCommand accessCommand = new OleDbCommand(sentencia, base.Conector);
                accessCommand.Parameters.AddWithValue("leg", legajo);
                {
                    base.Conector.Open();
                }
                int filasAfectadas = accessCommand.ExecuteNonQuery();
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
    }
}

