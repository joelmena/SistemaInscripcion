using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace INF518.Connection
{
    public class DbManager
    {
        private string StrConnection;
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }

        public DbManager()
        {
            this.StrConnection = ConfigurationManager.ConnectionStrings["cnn"].ToString();
            this.Connection = new SqlConnection(this.StrConnection);
            this.Command = new SqlCommand();
            this.Command.CommandTimeout = 30;
        }
    }
}
