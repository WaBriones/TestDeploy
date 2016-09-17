using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSurvery.API.BusinessObjects
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }
    }
}
