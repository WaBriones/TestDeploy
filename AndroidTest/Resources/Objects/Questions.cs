using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Questions
    {
        public int QuestionID { get; set; }

        public string Question { get; set; }

        public List<Choices> Choices { get; set; }
    }

    
}
