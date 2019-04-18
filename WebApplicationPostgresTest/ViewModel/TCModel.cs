using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationPostgresTest.ViewModel
{
    public class TCModel
    {
        public string id { get; set; }
        public DateTime timestamp { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public double speed { get; set; }
        public short bearing { get; set; }
        public double altitude { get; set; }
        public double accuracy { get; set; }
        public double batt { get; set; }
    }
}
