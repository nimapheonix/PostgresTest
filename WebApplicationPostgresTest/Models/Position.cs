using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationPostgresTest.Models
{
    public class Position : BaseEntity
    {
        public string Protocol { get; set; }
        public string DeviceId { get; set; }
        [ForeignKey("DeviceId")]
        public Device Device { get; set; }
        public DateTime ServerTime { get; set; }
        public DateTime DeviceTime { get; set; }
        public DateTime Fixtime { get; set; }
        public bool Valid { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? Altitude { get; set; }
        public double? Speed { get; set; }
        public double ? Course { get; set; }
        public string Address { get; set; }
        public string Attributes { get; set; }
        public double ? Accuracy { get; set; }
        public string Network { get; set; }
    }
}
