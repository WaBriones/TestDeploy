using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSurvery.API.BusinessObjects
{
    public class Questions
    {

        public int QuestionID { get; set; }

        public string Question { get; set; }

        public List<Choices> Choices {get; set;}

    }
}
