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

            var distance = new GeoPoint[]
            {
                new GeoPoint{City1= "Islamabad", Latitude1=33.7214813, Longitude1=73.0432892,
                             City2= "Lahore", Latitude2=31.5580006, Longitude2=74.350708}
                
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