using INF518.Connection;
using System.Data.SqlClient;
using System.Data;
using Serilog.Events;
using Serilog;
using Serilog.Core;
using System;

namespace INF518.Clases
{
    public class Carrera : DbManager
    {
        private Logger logger;

        public Carrera()
        {
            logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();
        }


        #region PROPIEDADES
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public int Creditos { get; set; }
        public string Observaciones { get; set; }
        public bool Inactivo { get; set; }
        #endregion


        #region CRUD
        public bool Registrar()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_registrarCarrera";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@descripcion", this.Descripcion);
            this.Command.Parameters.AddWithValue("@creditos", this.Creditos);
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

        public DataTable Carreras(string filtro = "")
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_carreras";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@filtro", filtro);
            this.Command.Connection = this.Connection;

            SqlDataAdapter da = new SqlDataAdapter(this.Command);
            DataTable dt = new DataTable();

            try
            {
                this.Connection.Open();
                da.Fill(dt);

            }
            catch (System.Exception ex)
            {
                logger.Write(LogEventLevel.Error, ex.Message);
            }
            finally
            {
                this.Connection.Close();
            }
            return dt;
        }

        public Carrera Detalle()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_detalleCarrera";
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
                        this.Descripcion = this.Reader["Descripcion"].ToString();
                        this.Creditos = Convert.ToInt32(this.Reader["Creditos"].ToString());
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
            this.Command.CommandText = "sp_actualizarCarrera";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@id", this.ID);
            this.Command.Parameters.AddWithValue("@descripcion", this.Descripcion);
            this.Command.Parameters.AddWithValue("@creditos", this.Creditos);
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
