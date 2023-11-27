using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Market_Place
{
    internal class Pim
    {
        public SqlConnection obterConexao()
        {
            SqlConnection conn = null;
            string connectionString = "Data Source=Pim.db";
            conn = new SqlConnection(connectionString);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
    }
}
