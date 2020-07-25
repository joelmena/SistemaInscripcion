using INF518.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518.Clases
{
    public class Role : DbManager
    {
        public Role()
        {

        }


        #region PROPIEDADES
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool Inactivo { get; set; }
        #endregion


        #region CRUD
        public void Registrar()
        {

        }

        public DataTable Roles()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_roles";
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
                this.Connection.Close();
            }
            return dt;
        }
        #endregion
    }
}
