using MOOGPS.Interfaces;
using MOOGPS.Models;
using System.Collections.Generic;
using System.Linq;

namespace MOOGPS.Repositories
{
    public class LocationRepository : ILOcation
    {
        private readonly AppDbContext _context;

        public LocationRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreateLocation(Location gps)
        {
            _context.Locations.Add(gps);
            _context.SaveChanges();
        }


        public List<Location> GetLocations()
        {
            return _context.Locations.ToList();
        }
    }
}
