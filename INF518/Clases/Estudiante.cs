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
    public class Estudiante : DbManager
    {
        private Logger logger;

        public Estudiante()
        {
            logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();
        }

        #region PROPIEDADES
        public int ID { get; set; }
        public int Matricula { get; set; }
        public int IdEstadoCivil { get; set; }
        public int IdTipoEstudiante { get; set; }
        public int IdCarrera { get; set; }

        public decimal Balance { get; set; }


        public char Sexo { get; set; }


        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoMovil { get; set; }
        public string Direccion { get; set; }
        public string Observaciones { get; set; }
        public string UrlFoto { get; set; }


        public DateTime FechaNacimiento { get; set; }
        #endregion


        #region CRUD
        public bool Registrar(int idUsuario)
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_registrarEstudiante";
            this.Command.Parameters.Clear();
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
            this.Command.Parameters.AddWithValue("@idCarrera", this.IdCarrera);
            this.Command.Parameters.AddWithValue("@idTipoEstudiante", this.IdTipoEstudiante);
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

        public DataTable Estudiantes(string filtro = "")
        {
            DataTable dt = new DataTable();

            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_estudiantes";
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

        public Estudiante Detalle()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_detalleEstudiante";
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
                        this.IdCarrera = Convert.ToInt32(this.Reader["IdCarrera"].ToString());
                        this.IdTipoEstudiante = Convert.ToInt32(this.Reader["IdTipoEstudiante"].ToString());
                        this.Matricula = Convert.ToInt32(this.Reader["Matricula"].ToString());
                        this.Balance = Convert.ToDecimal(this.Reader["Balance"].ToString());
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
            this.Command.CommandText = "sp_actualizarEstudiante";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@idEstudiante", this.ID);
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
            this.Command.Parameters.AddWithValue("@idCarrera", this.IdCarrera);
            this.Command.Parameters.AddWithValue("@idTipoEstudiante", this.IdTipoEstudiante);
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

        //public decimal Balance()
        //{
        //    decimal balance = 0.00M;

        //    this.Command.CommandType = CommandType.StoredProcedure;
        //    this.Command.CommandText = "sp_balance";
        //    this.Command.Parameters.Clear();
        //    this.Command.Parameters.AddWithValue("@id", this.ID);
        //    this.Command.Connection = this.Connection;

        //    try
        //    {
        //        this.Connection.Open();
        //        this.Reader = this.Command.ExecuteReader();

        //        if (this.Reader != null && this.Reader.HasRows)
        //        {
        //            if (this.Reader.Read())
        //            {
        //                balance = this.Reader.GetDecimal(0);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Write(LogEventLevel.Error, ex.Message);
        //    }
        //    return balance;
        //}


        #endregion

    }
}
