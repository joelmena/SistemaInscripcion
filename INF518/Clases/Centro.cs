using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using INF518.Connection;
using Serilog.Core;
using System.Data;
using Serilog.Events;
using System.Data.SqlClient;

namespace INF518.Clases
{
    public class Centro : DbManager
    {
        private Logger logger;

        public Centro()
        {
            logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();
        }

        #region PROPIEDADES
        public int ID { get; set; }
        
        public string Descripcion { get; set; }
        public string NombreCorto { get; set; }
        public string WebSite { get; set; }
        public string Telefono { get; set; }
        public string Observaciones { get; set; }
        public string UrlLogo { get; set; }

        public bool Inactivo { get; set; }
        #endregion


        #region CRUD
        public bool Registrar()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_registrarCentro";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@descripcion", this.Descripcion);
            this.Command.Parameters.AddWithValue("@nombreCorto", this.NombreCorto);
            this.Command.Parameters.AddWithValue("@webSite", this.WebSite);
            this.Command.Parameters.AddWithValue("@telefono", this.Telefono);
            this.Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
            this.Command.Parameters.AddWithValue("@urlLogo", this.UrlLogo);
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

        public DataTable Centros(string filtro = "")
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_centros";
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

        public Centro Detalle()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_detalleCentro";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@id", this.ID);
            this.Command.Connection = this.Connection;

            try
            {
                this.Connection.Open();
                this.Reader = this.Command.ExecuteReader();

                if (this.Reader != null && this.Reader.HasRows)
                {
                    if(this.Reader.Read())
                    {
                        this.ID = Convert.ToInt32(this.Reader["ID"].ToString());
                        this.Descripcion = this.Reader["Descripcion"].ToString();
                        this.NombreCorto = this.Reader["NombreCorto"].ToString();
                        this.WebSite = this.Reader["WebSite"].ToString();
                        this.Telefono = this.Reader["Telefono"].ToString();
                        this.Observaciones = this.Reader["Observaciones"].ToString();
                        this.UrlLogo= this.Reader["UrlLogo"].ToString();
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
            this.Command.CommandText = "sp_actualizarCentro";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@id", this.ID);
            this.Command.Parameters.AddWithValue("@descripcion", this.Descripcion);
            this.Command.Parameters.AddWithValue("@nombreCorto", this.NombreCorto);
            this.Command.Parameters.AddWithValue("@webSite", this.WebSite);
            this.Command.Parameters.AddWithValue("@telefono", this.Telefono);
            this.Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
            this.Command.Parameters.AddWithValue("@urlLogo", this.UrlLogo);
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
