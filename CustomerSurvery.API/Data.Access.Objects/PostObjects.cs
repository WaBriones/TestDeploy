using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerSurvery.API.BusinessObjects;

namespace WebAPI2.Data.Access.Objects
{
    public class PostObjects
    {
        private readonly DBHelper _dbhelper;
        public PostObjects(DBHelper dbHelper)
        {
            _dbhelper = dbHelper;
        }

        public bool InsertCustomer(Customer cust)
        {
            var sb = new StringBuilder();
            var result = 0;

            sb.AppendLine("INSERT INTO dbo.CustomerInfo(Name,Age,Gender)");
            sb.AppendLine(string.Format("VALUES ('{0}', '{1}', '{2}')", cust.Name, cust.Age, cust.Gender));

            using (var cmd = new SqlCommand(sb.ToString(), _dbhelper.SQLConnection))
            {
                cmd.Connection.Open();
                result = cmd.ExecuteNonQuery();
            }


            return result > 0;
        }

        public bool InsertData(SurveyData quest)
        {
            var sb = new StringBuilder();
            var result = 0;

            sb.AppendLine("INSERT INTO dbo.CustomerInfo(Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10)");
            sb.AppendLine(string.Format("VALUES ('{0}', '{1}', '{2}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',)"
          ,quest.Question1, quest.Question2, quest.Question3,quest.Question4,quest.Question5,quest.Question6,quest.Question7,quest.Question8,quest.Question9,quest.Question10));

            using (var cmd = new SqlCommand(sb.ToString(), _dbhelper.SQLConnection))
            {
                cmd.Connection.Open();
                result = cmd.ExecuteNonQuery();
            }


            return result > 0;
        }



        public List<Customer> GetAllCustomers()
        {
            var sb = new StringBuilder();
            var customerList = new List<Customer>();
            sb.AppendLine("SELECT * FROM dbo.CustomerInfo");

            using(var cmd = new SqlCommand(sb.ToString(), _dbhelper.SQLConnection))
            {
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        customerList.Add(new Customer
                        {
                            CustomerID = (int)reader["CustomerID"],
                            Name = reader["Name"].ToString(),
                            Age = (int)reader["Age"],
                            Gender = reader["Gender"].ToString()
                        });
                    }
                }
            }

            return customerList;
        }

    }
}
