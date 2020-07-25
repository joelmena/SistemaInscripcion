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
    public class Profesor : DbManager
    {
        private Logger logger;

        public Profesor()
        {
            logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();
        }

        #region PROPIEDADES
        public int ID { get; set; }
        public int IdEstadoCivil { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public int DeletedBy { get; set; }


        public char Sexo { get; set; }


        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoMovil { get; set; }
        public string Direccion { get; set; }
        public string UrlFoto { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }


        public DateTime FechaNacimiento { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public bool Inactivo { get; set; }
        #endregion


        #region CRUD
        public bool Registrar(int idUsuario)
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_registrarProfesor";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@nombre", this.Nombre);
            this.Command.Parameters.AddWithValue("@apellido", this.Apellidos);
            this.Command.Parameters.AddWithValue("@cedula", this.Cedula);
            this.Command.Parameters.AddWithValue("@sexo", this.Sexo);
            this.Command.Parameters.AddWithValue("@fechaNacimiento", this.FechaNacimiento);
            this.Command.Parameters.AddWithValue("@IdEstadoCivil", this.IdEstadoCivil);
            this.Command.Parameters.AddWithValue("@telefonoCasa", this.TelefonoCasa);
            this.Command.Parameters.AddWithValue("@telefonoMovil", this.TelefonoMovil);
            this.Command.Parameters.AddWithValue("@direccion", this.Direccion);
            this.Command.Parameters.AddWithValue("@email", Email);
            this.Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
            this.Command.Parameters.AddWithValue("@urlFoto", this.UrlFoto);
            this.Command.Parameters.AddWithValue("@idUsuario", idUsuario);

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

        public DataTable Profesores(string filtro = "")
        {
            DataTable dt = new DataTable();

            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_profesores";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@filtro", filtro);
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

        public Profesor Detalle()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_detalleProfesor";
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
                        this.Nombre = this.Reader["Nombre"].ToString();
                        this.Apellidos = this.Reader["Apellido"].ToString();
                        this.Cedula = this.Reader["Cedula"].ToString();
                        this.Sexo = Convert.ToChar(this.Reader["Sexo"].ToString());
                        this.IdEstadoCivil = Convert.ToInt32(this.Reader["IdEstadoCivil"].ToString());
                        this.FechaNacimiento = Convert.ToDateTime(this.Reader["FechaNacimiento"].ToString());
                        this.TelefonoCasa = this.Reader["TelefonoCasa"].ToString();
                        this.TelefonoMovil = this.Reader["TelefonoMovil"].ToString();
                        this.Direccion = this.Reader["Direccion"].ToString();
                        this.Email = this.Reader["Email"].ToString();
                        this.Observaciones = this.Reader["Observaciones"].ToString();
                        this.UrlFoto = this.Reader["UrlFoto"].ToString();
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

        public bool Actualizar(int idUsuario)
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_actualizarProfesor";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@idProfesor", this.ID);
            this.Command.Parameters.AddWithValue("@nombre", this.Nombre);
            this.Command.Parameters.AddWithValue("@apellido", this.Apellidos);
            this.Command.Parameters.AddWithValue("@cedula", this.Cedula);
            this.Command.Parameters.AddWithValue("@sexo", this.Sexo);
            this.Command.Parameters.AddWithValue("@fechaNacimiento", this.FechaNacimiento);
            this.Command.Parameters.AddWithValue("@IdEstadoCivil", this.IdEstadoCivil);
            this.Command.Parameters.AddWithValue("@email", Email);
            this.Command.Parameters.AddWithValue("@telefonoCasa", this.TelefonoCasa);
            this.Command.Parameters.AddWithValue("@telefonoMovil", this.TelefonoMovil);
            this.Command.Parameters.AddWithValue("@direccion", this.Direccion);
            this.Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
            this.Command.Parameters.AddWithValue("@urlFoto", this.UrlFoto);
            this.Command.Parameters.AddWithValue("@idUsuario", idUsuario);

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

        public DataTable CbProfesores(string filtro = "")
        {
            DataTable dt = new DataTable();

            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_cbProfesores";
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
        #endregion
    }
}
