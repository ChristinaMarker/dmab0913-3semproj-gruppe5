using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    class Station
    {
        private List<Battery> batteryList;
        private string name;
        private string address;
        private int zipcode;
        private string city;
        private double longitude;
        private double latitude;

        /// <summary>
        /// Constructor for the station class
        /// </summary>
        /// <param name="name">The name of the station</param>
        /// <param name="address">The address of the station</param>
        /// <param name="zipcode">The zipcode of the station</param>
        /// <param name="city">The city the station is in</param>
        /// <param name="longitude">The longitude of the station</param>
        /// <param name="latitude">The latitude of the station</param>
        Station(String name, String address, int zipcode, String city, int longitude, int latitude)
        {
            this.name = name;
            this.address = address;
            this.zipcode = zipcode;
            this.city = city;
            this.longitude = longitude;
            this.latitude = latitude;
            batteryList = new List<Battery>();
        }

        /// <summary>
        /// Implements are method to add batteries to a list
        /// </summary>
        /// <param name="battery">The battery object to add</param>
        public void addBattery(Battery battery)
        {
            batteryList.Add(battery);
        }

        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public int Zipcode { get { return zipcode; } set { zipcode = value; } }
        public string City { get { return city; } set { city = value; } }
        public double Longitude { get { return longitude; } set { longitude = value; } }
        public double Latitude { get { return latitude; } set { latitude = value; } }
    }
}
