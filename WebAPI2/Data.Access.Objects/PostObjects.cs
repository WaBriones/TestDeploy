using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace WebAPI2.Data.Access.Objects
{
    public class PostObjects
    {
        public PostObjects()
        {

        }

        public bool InsertCustomer(Customer cust)
        {
            var sb = new StringBuilder();
            var result = 0;
            //var userInfo = GetUser(user);

            
                sb.AppendLine("INSERT INTO dbo.CustomerInfo(Name,Age,Gender)");
                sb.AppendLine(string.Format("VALUES ('{0}', '{1}', '{2}')", cust.Name, cust.Age, cust.Gender));

                using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
                {
                    cmd.Connection.Open();
                    result = cmd.ExecuteNonQuery();
                }
            

            return result > 0;
        }

    }
}
