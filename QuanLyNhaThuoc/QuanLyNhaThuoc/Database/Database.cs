using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc
{
    class Database
    {
        // Ket noi co so du lieu
        public static SqlConnection getConnection()
        {
            string username = "sa";
            string password = "123456";
            string database = "quanlynhathuoc";
            string datasource = @"THANTIENBUT-PC\SQLEXPRESS";
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
