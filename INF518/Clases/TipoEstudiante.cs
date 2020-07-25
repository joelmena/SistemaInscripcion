using INF518.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518.Clases
{
    public class TipoEstudiante : DbManager
    {
        #region PROPIEDADES
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public decimal CostoCredito { get; set; }
        public decimal CostoInscripcion { get; set; }
        public string Observaciones { get; set; }
        public bool Inactivo { get; set; }
        #endregion

        #region CRUD
        public DataTable Listado()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_tiposEstudiante";
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

                throw;
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
