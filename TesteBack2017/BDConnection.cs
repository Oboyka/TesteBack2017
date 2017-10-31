using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TesteBack2017
{
    class BDConnection
    {
        public static SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection("Server=tcp:pedrolssilva.database.windows.net,1433;Initial Catalog=pl;Persist Security Info=False;User ID=pedrolssilva;Password=123Mudar;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            conn.Open();

            return conn;
        }

    }
}
