using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INF518.Connection;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace INF518.Clases
{
    public class Asignatura : DbManager
    {
        private Logger logger;

        public Asignatura()
        {
            logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();
        }

        #region PROPIEDADES
        public int ID { get; set; }
        public int IdCarrera { get; set; }
        public int Creditos { get; set; }


        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        
        public bool Inactivo { get; set; }
        #endregion


        #region CRUD
        public bool Registrar()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_registrarAsignatura";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@codigo", this.Codigo);
            this.Command.Parameters.AddWithValue("@descripcion", this.Descripcion);
            this.Command.Parameters.AddWithValue("@idCarrera", this.IdCarrera);
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

        public DataTable Asignaturas(string filtro = "")
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_asignaturas";
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

        public Asignatura Detalle()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_detalleAsignatura";
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
                        this.IdCarrera= Convert.ToInt32(this.Reader["IdCarrera"].ToString());
                        this.Codigo = this.Reader["Codigo"].ToString();
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
            this.Command.CommandText = "sp_actualizarAsignatura";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@id", this.ID);
            this.Command.Parameters.AddWithValue("@codigo", this.Codigo);
            this.Command.Parameters.AddWithValue("@descripcion", this.Descripcion);
            this.Command.Parameters.AddWithValue("@idCarrera", this.IdCarrera);
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
