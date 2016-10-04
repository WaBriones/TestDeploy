using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerSurvery.API.BusinessObjects;


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

        public List<Questions> GetQuestions()
        {
            var sb = new StringBuilder();
            var questions = new List<Questions>();

            sb.AppendLine("SELECT questions.QuestionID, questions.Question, choice.ChoicesID, choice.QuestionTypeID, choice.Choices FROM dbo.Questions questions JOIN dbo.Choices choice ON questions.QuestionID = choice.QuestionID");

            using (var cmd = new SqlCommand(sb.ToString(), _dbHelper.SQLConnection))
            {
                cmd.Connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    Questions lastQuestion = null;
                    while (reader.HasRows && reader.Read())
                    {

                        if (lastQuestion == null || (int)reader["QuestionID"] != lastQuestion.QuestionID)
                        {
                            var question = new Questions();

                            question.QuestionID = reader["QuestionID"] != null ? (int)reader["QuestionID"] : 0;
                            question.Question = reader["Question"].ToString();

                            questions.Add(question);
                            lastQuestion = question;
                        }

                        var choices = new Choices();
                        choices.QuestionID = (int)reader["QuestionID"];
                        choices.ChoicesID = (int)reader["ChoicesID"];
                        choices.ChoicesLabel = reader["Choices"] != null ? reader["Choices"].ToString() : string.Empty;
                        choices.QuestionTypeID = (int)reader["QuestionTypeID"];

                        if (lastQuestion.Choices == null)
                        {
                            lastQuestion.Choices = new List<Choices>();
                        }

                        lastQuestion.Choices.Add(choices);
                    }
                }
            }
            return questions;
        }

    }
}
