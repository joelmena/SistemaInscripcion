using INF518.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Sinks.File;
using Serilog.Core;
using Serilog.Events;
using System.Data.SqlClient;

namespace INF518.Clases
{
    public class Aula : DbManager
    {
        private Logger logger;
        public Aula()
        {
            logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();
        }

        #region PROPIEDADES
        public int ID { get; set; }
        public int IdCentro { get; set; }
        public int Capacidad { get; set; }


        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public string Observaciones { get; set; }
        
        public bool Inactivo { get; set; }
        #endregion


        #region CRUD
        public bool Registrar()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_registrarAula";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@descripcion", this.Descripcion);
            this.Command.Parameters.AddWithValue("@codigo", this.Codigo);
            this.Command.Parameters.AddWithValue("@capacidad", this.Capacidad);
            this.Command.Parameters.AddWithValue("@idCentro", this.IdCentro);
            this.Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
            this.Command.Connection = this.Connection;

            try
            {
                this.Connection.Open();
                this.Command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                logger.Write(LogEventLevel.Error, ex.Message);
            }
            finally
            {
                this.Connection.Close();
            }
            return false;
        }

        public DataTable Aulas(string filtro = "")
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_aulas";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@filtro", filtro);
            this.Command.Connection = this.Connection;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(this.Command);

            try
            {
                this.Connection.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                logger.Write(LogEventLevel.Error, ex.Message);
            }
            finally
            {
                this.Connection.Close();
            }

            return dt;
        }

        public Aula Detalle()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_detalleAula";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@id", this.ID);
            this.Command.Connection = this.Connection;

            try
            {
                this.Connection.Open();
                this.Reader = this.Command.ExecuteReader();

                if (this.Reader != null && this.Reader.HasRows)
                {
                    if (this.Reader.Read())
                    {
                        this.ID = Convert.ToInt32(this.Reader["ID"].ToString());
                        this.IdCentro = Convert.ToInt32(this.Reader["IdCentro"].ToString());
                        this.Descripcion = this.Reader["Descripcion"].ToString();
                        this.Codigo = this.Reader["Codigo"].ToString();
                        this.Capacidad = Convert.ToInt32(this.Reader["Capacidad"].ToString());
                        this.Observaciones = this.Reader["Observaciones"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Write(LogEventLevel.Error, ex.Message);
            }
            finally
            {
                this.Connection.Close();
            }

            return this;
        }

        public bool Actualizar()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_actualizarAula";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@id", this.ID);
            this.Command.Parameters.AddWithValue("@descripcion", this.Descripcion);
            this.Command.Parameters.AddWithValue("@codigo", this.Codigo);
            this.Command.Parameters.AddWithValue("@capacidad", this.Capacidad);
            this.Command.Parameters.AddWithValue("@idCentro", this.IdCentro);
            this.Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
            this.Command.Connection = this.Connection;

            try
            {
                this.Connection.Open();
                this.Command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                logger.Write(LogEventLevel.Error, ex.Message);
            }
            finally
            {
                this.Connection.Close();
            }
            return false;
        }
        #endregion
    }
}
