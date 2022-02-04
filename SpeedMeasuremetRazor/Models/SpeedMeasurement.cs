using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedMeasuremetRazor.Models
{
    public class SpeedMeasurement
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _dateTime;

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        private int _speed;

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        private string _imagename;

        public string Imagename
        {
            get { return _imagename; }
            set { _imagename = value; }
        }

        public SpeedMeasurement(int id, int speed, string imagename,Location location)
        {
            _id = id;
            _dateTime = DateTime.Now;
            _speed = speed;
            _imagename = imagename;
            _location = location;
        }

        private Location _location;

        public Location Location
        {
            get { return _location; }
            set { _location = value; }
        }

    }
}
