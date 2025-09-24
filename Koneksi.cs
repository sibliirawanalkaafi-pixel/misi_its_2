using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PertemuanHariKe_2
{
    internal class Koneksi
    {
        public static SqlConnection GetConnection()
        {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TokoDB;Integrated Security=True;";
            return new SqlConnection(connectionString);
        }
    }
}
