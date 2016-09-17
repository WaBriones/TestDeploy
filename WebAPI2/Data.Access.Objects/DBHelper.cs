using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2
{
    public class DBHelper
    {
        private static SqlConnection _SQLConnection;
        public static SqlConnection SQLConnection
        {
            get
            {
                return _SQLConnection ?? InitializeConnectionString();
            }
            set
            {
                _SQLConnection = value;

            }

        }

        public static SqlConnection InitializeConnectionString()
        {
            return new SqlConnection(@"Data Source=DESKTOP-M3P6Q8G;Initial Catalog=BackEnd;Integrated Security=True");
        }
    }
}
