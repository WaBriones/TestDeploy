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
        public DataObjects()
        {

        }

        public static class pass
        {
            public static string qname;
            public static string qid;

        }


        public Questions GetQuestion1(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 1");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       qInfo.Question = reader["Question"].ToString();
                       pass.qname = reader["Question"].ToString();
                      
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion2(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 2");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                       
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion3(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 3");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                    
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion4(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 4");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                     
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion5(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 5");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                     
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion6(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 6");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                       
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion7(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 7");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
              
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion8(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 8");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
           
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion9(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 9");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
       
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion10(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 10");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();


                    }
                }

                return qInfo;
            }

        }
        public Questions GetQuestion11(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 11");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                        
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion12(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 12");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();

                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion13(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 13");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                       
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion14(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 14");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                      
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion15(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 15");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
     
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion16(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 16");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                      
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion17(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 17");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                       
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion18(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 18");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();

                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion19(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 19");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                      
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion20(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 20");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                       
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion21(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 21");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                       
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion22(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 22");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                      
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion23(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 23");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                       
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion24(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 24");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                      
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion25(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 25");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                      
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion26(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 26");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                      
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion27(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 27");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                      
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion28(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 28");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                   
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion29(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 29");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                     
                    }

                }
            }

            return qInfo;
        }

        public Questions GetQuestion30(Questions quest)
        {
            var qInfo = new Questions();
            var sb = new StringBuilder();

            sb.AppendLine("SELECT Question FROM dbo.Results WHERE QuestionID = 30");

            using (var cmd = new SqlCommand(sb.ToString(), DBHelper.SQLConnection))
            {
                cmd.Connection.Open();
                cmd.Parameters.Add(new SqlParameter("@QuestionID", quest.QuestionID));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qInfo.Question = reader["Question"].ToString();
                        pass.qname = reader["Question"].ToString();
                    
                    }

                }
            }

            return qInfo;
        }


    }
}
