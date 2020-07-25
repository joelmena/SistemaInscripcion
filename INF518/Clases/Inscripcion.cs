using INF518.Connection;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518.Clases
{
    public class Inscripcion : DbManager
    {
        private Logger logger;
        public Inscripcion()
        {
            logger = new Serilog.LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();
        }

        #region PROPIEDADES
        public int ID { get; set; }
        public int IdEstudiante { get; set; }
        public DateTime Fecha { get; set; }
        public bool Inactivo { get; set; }
        #endregion

        #region CRUD
        public bool Registrar(int idSeccion)
        {
            bool succees = false;
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_registrarInscripcion";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@idEstudiante", this.IdEstudiante);
            this.Command.Parameters.AddWithValue("@idSeccion", idSeccion);
            this.Command.Connection = this.Connection;

            try
            {
                this.Connection.Open();
                this.Command.ExecuteNonQuery();
                succees = true;
            }
            catch (Exception ex)
            {
                logger.Write(LogEventLevel.Error, ex.Message);
            }
            finally
            {
                this.Connection.Close();
            }
            return succees;
        }

        public DataTable Inscripciones()
        {
            DataTable dt = new DataTable();

            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_inscripciones";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@idEstudiante", this.IdEstudiante);
            this.Command.Connection = this.Connection;

            var da = new SqlDataAdapter(this.Command);

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

        public DataTable Secciones(string filtro = "")
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_seccionesAsignaturas";
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

        #endregion


    }
}
