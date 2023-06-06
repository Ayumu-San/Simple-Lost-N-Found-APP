using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TsunnagaruConnect
{
    internal class Koneksi
    {
        public SqlConnection Getconn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source = MIFUNE-UEHR\\NIJIGASAKIHS; Initial Catalog =DBNyobaCRUD; Integrated Security = True";
            return Conn;
        }
    }
}
