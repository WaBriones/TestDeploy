using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSurvery.API.BusinessObjects
{
    public class SurveyData
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int SurveyNo { get; set; }
        
    }

    public class SurveyAnswer
    {
        public int CustomerId { get; set; }

        public int QuestionId { get; set; }

        public int ChoiceId { get; set; }
    }
}
