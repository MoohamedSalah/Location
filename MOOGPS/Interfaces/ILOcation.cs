using MOOGPS.Models;
using System.Collections.Generic;

namespace MOOGPS.Interfaces
{
    public interface ILOcation
    {
        List<Location> GetLocations();

        void CreateLocation(Location gps);
    }
}
