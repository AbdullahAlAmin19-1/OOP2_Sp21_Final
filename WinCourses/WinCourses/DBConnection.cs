using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinCourses
{
    class DBConnection
    {
        public static SqlConnection Connect()
        {
            string connString = @"Server=AL-AMIN\SQLEXPRESS;Database=courses;Integrated Security=true;MultipleActiveResultSets=True;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
