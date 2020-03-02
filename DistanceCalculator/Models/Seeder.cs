using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistanceCalculator.Models
{
    public class Seeder
    {
        private ApplicationDBContext _context;

        public Seeder(ApplicationDBContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Database.EnsureCreated();
            if (_context.geoPoints.Any())
            {
                return;
            }

            var distance = new List<GeoPoint>()
            {
                new GeoPoint{City1= "Islamabad", Latitude1=33.738045, Longitude1=73.084488,
                            City2= "Lahore", Latitude2=31.582045, Longitude2=74.329376},

                new GeoPoint{City1= "Multan,Pakistan", Latitude1=30.181459, Longitude1=71.492157,
                            City2= "Bahawalpur", Latitude2=29.418068, Longitude2=71.670685},

                new GeoPoint{City1= "Sheikhupura, Pakistan", Latitude1=31.716661, Longitude1=73.985023,
                            City2= "Karachi", Latitude2=24.926294, Longitude2=67.022095},
                 new GeoPoint{City1= "Wah, Pakistan", Latitude1=33.783184, Longitude1=72.723076,
                            City2= "Rawalpindi, Pakistan", Latitude2=33.626057, Longitude2=73.071442}

            };

            foreach (GeoPoint g in distance)
            {
                _context.geoPoints.Add(g);
            }
            _context.AddRange(distance);
            _context.SaveChanges();

        }
    }
}