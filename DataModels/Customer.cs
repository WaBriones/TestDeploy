using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }
       
    }
   
}
