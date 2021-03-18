using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseApp.Models
{
    public class Car
    {
        public int CarID { get; set; }

        public string Model { get; set; }

        public string Make { get; set; }

        public string EngineSize { get; set; }

        public string Type { get; set; }

        public int ManufacturerID { get; set; }

        //public Manufacturer manufacturer { get; set; }


    }
}
