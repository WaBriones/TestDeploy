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

        public Customer InsertCustomer(Customer cust)
        {
            var sb = new StringBuilder();
            var result = 0;

            sb.AppendLine("INSERT INTO dbo.CustomerInfo(Name,Age,Gender)");
            sb.AppendLine(string.Format("OUTPUT INSERTED.CustomerID VALUES ('{0}', '{1}', '{2}');", cust.Name, cust.Age, cust.Gender));
            

            using (var cmd = new SqlCommand(sb.ToString(), _dbhelper.SQLConnection))
            {
                cmd.Connection.Open();
                cust.CustomerID = (int)cmd.ExecuteScalar();
            }
            
            return cust;
        }


        public SurveyData InsertInitilSurveyData(Customer cust)
        {
            var sb = new StringBuilder();
            var result = new SurveyData();

            sb.AppendLine("INSERT INTO dbo.SurveyData(Name,Age,Gender, CustomerID)");
            sb.AppendLine(string.Format("OUTPUT INSERTED.SurveyNo VALUES ('{0}', '{1}', '{2}', '{3}')", cust.Name, cust.Age, cust.Gender, cust.CustomerID));

            using (var cmd = new SqlCommand(sb.ToString(), _dbhelper.SQLConnection))
            {
                cmd.Connection.Open();
                result.SurveyNo = (int) cmd.ExecuteScalar();
            }

            result.CustomerID = cust.CustomerID;
            result.Name = cust.Name;
            result.Age = cust.Age;
            result.Gender = cust.Gender;

            return result;
        }



        public bool InsertData(List<SurveyAnswer> surveyAnswers)
        {
            var sb = new StringBuilder();
            var result = 0;


            sb.AppendLine(
                "INSERT INTO dbo.SurveyAnswer (CustomerId, QuestionId, ChoiceId) VALUES (@CustomerId, @QuestionId, @ChoiceId)");

            using (var cmd = new SqlCommand(sb.ToString(), _dbhelper.SQLConnection))
            {
                cmd.Connection.Open();

                foreach (var surveyAnswer in surveyAnswers)
                {
                    cmd.Parameters.Add("@CustomerId", surveyAnswer.CustomerId);
                    cmd.Parameters.Add("@QuestionId", surveyAnswer.QuestionId);
                    cmd.Parameters.Add("@ChoiceId", surveyAnswer.ChoiceId);


                    result = cmd.ExecuteNonQuery();
                }
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
