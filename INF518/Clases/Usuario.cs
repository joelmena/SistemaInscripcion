using INF518.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoHelper;
using System.Security.Cryptography;

namespace INF518.Clases
{
    public class Usuario : DbManager
    {
        public Usuario()
        {

        }


        #region PROPIEDADES
        public int ID { get; set; }
        public int IdRole { get; set; }

        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string Observaciones { get; set; }
        public string Permisos { get; set; }

        public bool Inactivo { get; set; }
        #endregion


        #region CRUD
        public bool Registrar()
        {
            this.Password = Crypto.HashPassword(this.Password);
            bool success = false;
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_registrarUsuario";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@nombre", this.Nombre);
            this.Command.Parameters.AddWithValue("@usuario", this.NombreUsuario);
            this.Command.Parameters.AddWithValue("@password", this.Password);
            this.Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
            this.Command.Parameters.AddWithValue("@idRole", this.IdRole);
            this.Command.Connection = this.Connection;

            try
            {
                this.Connection.Open();
                this.Command.ExecuteNonQuery();
                success = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                this.Connection.Close();
            }

            return success;
        }

        public void Usuarios(string filtro = "")
        {

        }

        public Usuario Detalle()
        {
            return this;
        }

        public bool Actualizar()
        {
            bool success = false;
            try
            {
                this.Connection.Open();
                success = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                this.Connection.Close();
            }

            return success;
        }

        public int EsValido()
        {
            int userID = 0;
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_login";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@usuario", this.NombreUsuario);
            this.Command.Connection = this.Connection;

            try
            {
                this.Connection.Open();
                this.Reader = this.Command.ExecuteReader();

                if(this.Reader != null && this.Reader.HasRows)
                {
                    if(this.Reader.Read())
                    {
                        this.ID = Convert.ToInt32(this.Reader["ID"].ToString());
                        this.Nombre = this.Reader["Nombre"].ToString();
                        this.NombreUsuario = this.Reader["Usuario"].ToString();
                        this.PasswordHash = this.Reader["Password"].ToString();
                        this.Permisos = this.Reader["Permisos"].ToString();
                    }
                }
                userID = this.ID;
                //if(Crypto.VerifyHashedPassword(this.Password, this.PasswordHash))
                //{
                //    userID = this.ID;
                //}
            }
            catch (Exception ex)
            {

            }
            finally
            {
                this.Connection.Close();
            }
            return userID;
        }
        #endregion
    }
}
