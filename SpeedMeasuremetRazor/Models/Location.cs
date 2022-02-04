using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedMeasuremetRazor.Models
{
    public class Location
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private int _speedLimit;

        public int SpeedLimit
        {
            get { return _speedLimit; }
            set { _speedLimit = value; }
        }

        public Location(int id, string address, int speedLimit, Zone zone)
        {
            _id = id;
            _address = address;
            _speedLimit = speedLimit;
            _zone = zone;
        }
        public Location()
        {

        }

        private Zone _zone;

        public Zone Zone
        {
            get { return _zone; }
            set { _zone = value; }
        }

        //Der kan være en ToString-metode.
    }
}
