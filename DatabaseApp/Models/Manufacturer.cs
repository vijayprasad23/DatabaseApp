using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseApp.Models
{
    public class Manufacturer
    {
        public int ManufacturerID { get; set; }
        public string CompanyName { get; set; }

        public string Location { get; set; }

        public string Country { get; set; }

        //public Car car { get; set; }
    }
}
