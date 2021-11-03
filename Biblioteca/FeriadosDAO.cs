using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class FeriadosDAO : ConexionDAO
    {
        public event Biblioteca.InformarMensajes EnviarMensaje;
        public FeriadosDAO(string ruta) 
            : base(ruta)
        {
        }

        public List<Feriado> LeeDiasFeriadosDeLaBase()
        {
            List<Feriado> feriados = null;
            Feriado feriadoAux;
            try
            {
                string sentencia = "SELECT * FROM [T03-FERIADOS] ORDER BY FECHA ASC ";
                OleDbCommand accessCommand = new OleDbCommand(sentencia, base.Conector);
                if (base.Conector.State == System.Data.ConnectionState.Closed)
                {
                    base.Conector.Open();
                }
                OleDbDataReader accessDataReader = accessCommand.ExecuteReader();
                feriados = new List<Feriado>();
                while (accessDataReader.Read())
                {
                    feriadoAux =new Feriado( accessDataReader.GetDateTime(0),accessDataReader.GetString(1)); 
                    feriados.Add(feriadoAux);
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
            return feriados;
        }
        public void InsertarFeriados(Feriado feriado)
        {
            try
            {
                string sentencia = "INSERT INTO [T03-FERIADOS] (Fecha,Descripcion) " +
                    "VALUES (@Fecha,@Descripcion)";
                OleDbCommand accessCommand = new OleDbCommand(sentencia, base.Conector);
                accessCommand.Parameters.AddWithValue("Fecha", feriado.Fecha);
                accessCommand.Parameters.AddWithValue("Descripcion", feriado.Descripcion);
                if (base.Conector.State == System.Data.ConnectionState.Closed)
                {
                    base.Conector.Open();
                }
                accessCommand.ExecuteNonQuery();
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
        }

        public void BorraFeriado(Feriado feriado)
        {
            try
            {
                string sentencia = "DELETE FROM [T03-FERIADOS] WHERE [T03-FERIADOS].[Fecha]=@Fecha";
                OleDbCommand accessCommand = new OleDbCommand(sentencia, base.Conector);
                accessCommand.Parameters.AddWithValue("Fecha", feriado.Fecha.Date);
                {
                    base.Conector.Open();
                }
                int filasAfectadas = accessCommand.ExecuteNonQuery();
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
        }
    }
}
