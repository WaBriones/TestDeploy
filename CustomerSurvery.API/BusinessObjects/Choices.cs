using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSurvery.API.BusinessObjects
{
    public class Choices

    {
        public int QuestionID { get; set; }

        public int ChoicesID { get; set; }

        public string ChoicesLabel { get; set; }

        public int QuestionTypeID { get; set; }

    }
}
