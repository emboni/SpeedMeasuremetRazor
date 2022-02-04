using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SpeedMeasuremetRazor.Helpers;
using SpeedMeasuremetRazor.Interfaces;
using SpeedMeasuremetRazor.Models;

namespace SpeedMeasuremetRazor.Services
{


    public class LocationRepo : ILocationRepo
    {
        public List<Location> locations
        {
            get;
        }

        public LocationRepo()
        {
            locations = MockData.Locations;
        }

        public void AddLocation(Location location)
        {
            locations.Add(location);
        }

        public void DeleteLocation(int id)
        {
            //if-sætning om hvis noget bestemt eksisterer før, at man prøver at slette
        }

        public List<Location> GetAllLocations()
        {
            return locations;
        }

        public Location GetLocation(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateLocation(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
