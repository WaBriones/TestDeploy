using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    [Serializable]
    public class SurveyData
    {

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int SurveyNo { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string Question4 { get; set; }
        public string Question5 { get; set; }
        public string Question6 { get; set; }
        public string Question7 { get; set; }
        public string Question8 { get; set; }
        public string Question9 { get; set; }
        public string Question10 { get; set; }
        public string Question11 { get; set; }
        public string Question12 { get; set; }
        public string Question13 { get; set; }
        public string Question14 { get; set; }
        public string Question15 { get; set; }
        public string Question16 { get; set; }
        public string Question17 { get; set; }
        public string Question18 { get; set; }
        public string Question19 { get; set; }
        public string Question20 { get; set; }
        public string Question21 { get; set; }
        public string Question22 { get; set; }
        public string Question23 { get; set; }
        public string Question24 { get; set; }
        public string Question25 { get; set; }
        public string Question26 { get; set; }
        public string Question27 { get; set; }
        public string Question28 { get; set; }
        public string Question29 { get; set; }
        public string Question30 { get; set; }
        public DateTime DateTime { get; set; }

    }

    public class SurveyAnswer
    {
        public int CustomerId { get; set; }

        public int QuestionId { get; set; }

        public int ChoiceId  { get; set; }
    }
}
