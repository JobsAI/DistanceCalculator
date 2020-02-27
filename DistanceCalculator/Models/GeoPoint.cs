using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistanceCalculator.Models
{
    public class GeoPoint
    {
        public int Id { get; set; }
        public string City1 { get; set; }
        public double Longitude1 { get; set; }
        public double Latitude1 { get; set; }
        public string City2 { get; set; }
        public double Longitude2 { get; set; }
        public double Latitude2 { get; set; }
        public double Distance { get; set; }

    }
}
