using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DistanceCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DistanceCalculator.Controllers
{
    [TestClass]
    public class GeoPointController : Controller
    {
        private readonly ApplicationDBContext _context;
        public GeoPointController(ApplicationDBContext context)
        {
            _context = context;
        }
        public static double ToRadians(double val)
        {
            return (Math.PI / 180) * val;
        }
        double rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }
        [TestMethod]
        public IActionResult Index()
        {

            var model = _context.geoPoints.ToList();
            List<GeoPoint> geo = new List<GeoPoint>();
            foreach (var item in model)
            {
                var City1 = item.City1;
                var lattitude1 = item.Latitude1;
                var longitude1 = item.Longitude1;
                var City2 = item.City2;
                var lattitude2 = item.Latitude2;
                var longitude2 = item.Longitude2;
                Assert.IsNotNull(geo);

                double distance(double longitude1, double lattitude1, double longitude2, double lattitude2)
                {

                    if ((lattitude1 == lattitude2) && (longitude1 == longitude2))
                    {
                        return 0;
                    }
                    else
                    {
                        double theta = longitude1 - longitude2;
                        double dist = Math.Sin(ToRadians(lattitude1)) * Math.Sin(ToRadians(lattitude2)) +
                                     Math.Cos(ToRadians(lattitude1)) * Math.Cos(ToRadians(lattitude2))
                                     * Math.Cos(ToRadians(theta));
                        dist = Math.Acos(dist);
                        dist = rad2deg(dist);
                        dist = dist * 60 * 1.1515;
                        dist = dist * 1.609344;
                        dist = Math.Round(dist);
                           
                        return (dist);
                        
                    }
                   
                }

                GeoPoint gp = new GeoPoint();
                gp.City1 = City1;
                gp.City2 = City2;
                gp.Latitude1 = lattitude1;
                gp.Longitude1 = longitude1;
                gp.Latitude2 = lattitude2;
                gp.Longitude2 = longitude2;
                gp.Distance = distance(longitude1, lattitude1, longitude2, lattitude2);

                geo.Add(gp);
                Assert.IsNotNull(gp);
            }


            return View("Index", geo);
        }
    }
}