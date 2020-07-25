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
    public class EstadoCivil : DbManager
    {
        #region PROPIEDADES
        public int ID { get; set; }
        public string Descripcion { get; set; }
        #endregion


        #region CRUD
        public DataTable Listado()
        {
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandText = "sp_estadoCivil";
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

        //public List<EstadoCivil> List()
        //{
        //    this.Command.CommandType = CommandType.StoredProcedure;
        //    this.Command.CommandText = "sp_estadoCivil";
        //    this.Command.Connection = this.Connection;

        //    List<EstadoCivil> ec = new List<EstadoCivil>();

        //    try
        //    {
        //        this.Connection.Open();
        //        this.Reader = this.Command.ExecuteReader();

        //        if(this.Reader != null && this.Reader.HasRows)
        //        {
        //            while(this.Reader.Read())
        //            {
        //                ec.Add(new EstadoCivil
        //                {
        //                    ID = Convert.ToInt32(this.Reader["ID"].ToString()),
        //                    Descripcion = this.Reader["Nombre"].ToString()
        //                });
        //            }
        //        }    

        //    }
        //    catch (System.Exception ex)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        this.Connection.Close();
        //    }
        //    return ec;
        //}
        #endregion
    }
}
