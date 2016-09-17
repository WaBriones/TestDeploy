using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CustomerSurvery.API.Helpers;

namespace WebAPI2
{
    public class DBHelper
    {
        private SqlConnection _SQLConnection;
        public SqlConnection SQLConnection
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

        private readonly AppSettings _appSettings;
        public DBHelper(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public SqlConnection InitializeConnectionString()
        {
            return new SqlConnection(_appSettings.GetSetting("Data:ConnectionString"));
        }
    }
}
