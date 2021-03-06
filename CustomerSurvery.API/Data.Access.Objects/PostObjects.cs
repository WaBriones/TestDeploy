﻿using System;
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
            //var result = 0;

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

            sb.AppendLine("INSERT INTO dbo.SurveyData(CustomerID,Name,Age,Gender)");
            sb.AppendLine(string.Format("OUTPUT INSERTED.SurveyNo VALUES ('{0}', '{1}')", cust.CustomerID, cust.Name, cust.Age, cust.Gender));

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

        public bool InsertData(SurveyData quest)
        {
            var sb = new StringBuilder();
            var result = 0;

            sb.AppendLine("UPDATE dbo.SurveyData ");
            sb.AppendLine("Set Q1=@Q1,Q2=@Q2,Q3=@Q3,Q4=@Q4,Q5=@Q5,Q6=@Q6,Q7=@Q7,Q8=@Q8,Q9=@Q9,Q10=@Q10,Q11=@Q11,Q12=@Q12,Q13=@Q13,Q14=@Q14,Q15=@Q15,Q16=@Q16,Q17=@Q17,Q18=@Q18,Q19=@Q19,Q20=@Q20,Q21=@Q21,Q22=@Q22,Q23=@Q23,Q24=@Q24,Q25=@Q25,Q26=@Q26,Q27=@Q27,Q28=@Q28,Q29=@Q29,Q30=@Q30");
            sb.AppendLine("WHERE SurveyNo = @SurveyNo");

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Q1",quest.Question1),
                new SqlParameter("@Q2",quest.Question2),
                new SqlParameter("@Q3",quest.Question3),
                new SqlParameter("@Q4",quest.Question4),
                new SqlParameter("@Q5",quest.Question5),
                new SqlParameter("@Q6",quest.Question6),
                new SqlParameter("@Q7",quest.Question7),
                new SqlParameter("@Q8",quest.Question8),
                new SqlParameter("@Q9",quest.Question9),
                new SqlParameter("@Q10",quest.Question10),

                new SqlParameter("@Q11",quest.Question11),
                new SqlParameter("@Q12",quest.Question12),
                new SqlParameter("@Q13",quest.Question13),
                new SqlParameter("@Q14",quest.Question14),
                new SqlParameter("@Q15",quest.Question15),
                new SqlParameter("@Q16",quest.Question16),
                new SqlParameter("@Q17",quest.Question17),
                new SqlParameter("@Q18",quest.Question18),

                new SqlParameter("@Q19",quest.Question19),
                new SqlParameter("@Q20",quest.Question20),

                new SqlParameter("@Q21",quest.Question21),
                new SqlParameter("@Q22",quest.Question22),
                new SqlParameter("@Q23",quest.Question23),
                new SqlParameter("@Q24",quest.Question24),
                new SqlParameter("@Q25",quest.Question25),
                new SqlParameter("@Q26",quest.Question26),
                new SqlParameter("@Q27",quest.Question27),
                new SqlParameter("@Q28",quest.Question28),
                new SqlParameter("@Q29",quest.Question29),
                new SqlParameter("@Q30",quest.Question30),
                new SqlParameter("",quest.Question30)
            };



            using (var cmd = new SqlCommand(sb.ToString(), _dbhelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.AddRange(parameters.ToArray());
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


        public SurveyData insertAll(SurveyData cust)
        {
            var sb = new StringBuilder();
            //var result = 0;

            sb.AppendLine("INSERT INTO dbo.SurveyData (CustomerID,Name,Age,Gender,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Q12,Q13,Q14,Q15,Q16,Q17,Q18,Q19,Q20,Q21,Q22,Q23,Q24,Q25,Q26,Q27,Q28,Q29,Q30,DateTime)");
            sb.AppendLine(string.Format("OUTPUT INSERTED.SurveyNo VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}');", cust.CustomerID, cust.Name, cust.Age, cust.Gender,cust.Question1,cust.Question2,cust.Question3,cust.Question4,cust.Question5,cust.Question6,cust.Question7,cust.Question8,cust.Question9,cust.Question10,cust.Question11,cust.Question12,cust.Question13,cust.Question14,cust.Question15,cust.Question16,cust.Question17,cust.Question18,cust.Question19,cust.Question20,cust.Question21,cust.Question22,cust.Question23,cust.Question24,cust.Question25,cust.Question26,cust.Question27,cust.Question28,cust.Question29,cust.Question30, cust.DateTime));

            using (var cmd = new SqlCommand(sb.ToString(), _dbhelper.SQLConnection))
            {
                cmd.Connection.Open();
                cust.SurveyNo = (int)cmd.ExecuteScalar();

            }

            return cust;
        }

    }
}
