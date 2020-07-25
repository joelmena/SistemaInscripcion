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
    public class Seccion : DbManager
    {
        private Logger logger;

        public Seccion()
        {
            logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();
        }

        #region PROPIEDADES
        public int ID { get; set; }
        public int IdCentro { get; set; }
        public int IdAula { get; set; }
        public int IdCarrera { get; set; }
        public int IdProfesor { get; set; }
        public int Capacidad { get; set; }
        public int Numero { get; set; }
        public int IdAsignatura { get; set; }

        public string Dia1 { get; set; }
        public string Dia2 { get; set; }
        public string Observaciones { get; set; }


        public DateTime HoraInicio1 { get; set; }
        public DateTime HoraFin1 { get; set; }
        public DateTime HoraInicio2 { get; set; }
        public DateTime HoraFin2 { get; set; }

        #endregion


        #region CRUD
        public bool Registrar()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_registrarSeccion";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@idCentro", this.IdCentro);
            this.Command.Parameters.AddWithValue("@idAula", this.IdAula);
            this.Command.Parameters.AddWithValue("@idCarrera", this.IdCarrera);
            this.Command.Parameters.AddWithValue("@idProfesor", this.IdProfesor);
            this.Command.Parameters.AddWithValue("@Capacidad", this.Capacidad);
            this.Command.Parameters.AddWithValue("@dia1", this.Dia1);
            this.Command.Parameters.AddWithValue("@horaInicio1", this.HoraInicio1);
            this.Command.Parameters.AddWithValue("@horaFin1", this.HoraFin1);
            this.Command.Parameters.AddWithValue("@dia2", this.Dia2);
            this.Command.Parameters.AddWithValue("@horaInicio2", this.HoraInicio2);
            this.Command.Parameters.AddWithValue("@horaFin2", this.HoraFin2);
            this.Command.Parameters.AddWithValue("@numero", this.Numero);
            this.Command.Parameters.AddWithValue("@idAsignatura", this.IdAsignatura);
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

        public DataTable Secciones(string filtro = "")
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_Secciones";
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

        public Seccion Detalle()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_detalleSeccion";
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
                        this.IdAula = Convert.ToInt32(this.Reader["IdAula"].ToString());
                        this.IdCarrera = Convert.ToInt32(this.Reader["IdCarrera"].ToString());
                        this.IdProfesor= Convert.ToInt32(this.Reader["IdProfesor"].ToString());
                        this.Capacidad = Convert.ToInt32(this.Reader["Capacidad"].ToString());
                        this.Dia1 = this.Reader["Dia1"].ToString();
                        this.HoraInicio1 = Convert.ToDateTime(this.Reader["HoraInicio1"].ToString());
                        this.HoraFin1 = Convert.ToDateTime(this.Reader["HoraFin2"].ToString());
                        this.Dia2 = this.Reader["Dia2"].ToString();
                        this.HoraInicio2 = Convert.ToDateTime(this.Reader["HoraInicio2"].ToString());
                        this.HoraFin2 = Convert.ToDateTime(this.Reader["HoraFin2"].ToString());
                        this.Numero = Convert.ToInt32(this.Reader["Numero"].ToString());
                        this.IdAsignatura = Convert.ToInt32(this.Reader["IdAsignatura"].ToString());
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
            this.Command.CommandText = "sp_actualizarSeccion";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@id", this.ID);
            this.Command.Parameters.AddWithValue("@idCentro", this.IdCentro);
            this.Command.Parameters.AddWithValue("@idAula", this.IdAula);
            this.Command.Parameters.AddWithValue("@idCarrera", this.IdCarrera);
            this.Command.Parameters.AddWithValue("@idProfesor", this.IdProfesor);
            this.Command.Parameters.AddWithValue("@Capacidad", this.Capacidad);
            this.Command.Parameters.AddWithValue("@dia1", this.Dia1);
            this.Command.Parameters.AddWithValue("@HoraInicio1", this.HoraInicio1);
            this.Command.Parameters.AddWithValue("@HoraFin1", this.HoraFin1);
            this.Command.Parameters.AddWithValue("@dia2", this.Dia2);
            this.Command.Parameters.AddWithValue("@HoraInicio2", this.HoraInicio2);
            this.Command.Parameters.AddWithValue("@HoraFin2", this.HoraFin2);
            this.Command.Parameters.AddWithValue("@numero", this.Numero);
            this.Command.Parameters.AddWithValue("@idAsignatura", this.IdAsignatura);
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

        /*======================================*/
        public DataTable Horarios()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_horarios";
            this.Command.Parameters.Clear();
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

        public DataTable Dias()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_dias";
            this.Command.Parameters.Clear();
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
