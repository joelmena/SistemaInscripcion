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
    public class Cobro : DbManager
    {
        public Cobro()
        {

        }

        #region PROPIEDADES
        public int ID { get; set; }
        public int IdInscripcion { get; set; }
        public int IdEstudiante { get; set; }

        public decimal Monto { get; set; }
        public decimal Devuelta { get; set; }

        public DateTime Fecha { get; set; }
        #endregion


        #region CRUD
        public decimal Cobrar()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_cobrar";
            this.Command.Parameters.Clear();
            this.Command.Parameters.AddWithValue("@idInscripcion", this.IdInscripcion);
            this.Command.Parameters.AddWithValue("@idEstudiante", this.IdEstudiante);
            this.Command.Parameters.AddWithValue("@monto", this.Monto);
            this.Command.Connection = this.Connection;

            try
            {
                this.Connection.Open();
                this.Reader = this.Command.ExecuteReader();

                if(this.Reader != null  && this.Reader.HasRows)
                {
                    if(this.Reader.Read())
                    {
                        this.Devuelta = Convert.ToDecimal(this.Reader["devuelto"].ToString());
                    }
                }
                return this.Devuelta;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                this.Connection.Close();
            }
            return -1;
        }

        public DataTable Cuentas(string filtro = "")
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_cuentasPorCobrar";
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