using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace WebAPI2
{
    public class DataObjects
    {
        private readonly DBHelper _dbHelper;
        public DataObjects(DBHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public static class pass
        {
            public static string qname;
            public static string qid;

        }

        public Questions GetQuestionById(int id)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT * FROM dbo.Questions WHERE QuestionID = @QuestionId");

            using (var cmd = new SqlCommand(sb.ToString(), _dbHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionId", id));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                        qInfo.QuestionID = (int)reader["QuestionID"];
                    }

                }
            }

            return qInfo;
        }

        public List<Questions> GetAllQuestions()
        {
            var qInfo = new List<Questions>();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT * FROM dbo.Questions");

            using (var cmd = new SqlCommand(sb.ToString(), _dbHelper.SQLConnection))
            {
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Add(new Questions
                        {
                            QuestionID = (int)reader["QuestionID"],
                            Question = reader["Question"].ToString()

                        });
                    }

                }
            }

            return qInfo;
        }

    }
}
