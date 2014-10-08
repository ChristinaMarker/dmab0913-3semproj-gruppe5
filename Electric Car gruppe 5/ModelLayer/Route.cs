using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    class Route
    {
        private string startAddress;
        private int startZip;
        private string startCity;
        private string endAddress;
        private int endZip;
        private string endCity;

        /// <summary>
        /// Constructor for the Route class
        /// </summary>
        /// <param name="startAddress">The start address of Route</param>
        /// <param name="startZip">The start zipcode of the Route</param>
        /// <param name="startCity">The start city of the Route</param>
        /// <param name="endAddress">The end address of Route</param>
        /// <param name="endZip">The end zipcode of the Route</param>
        /// <param name="endCity">The end city of the Route</param>
        public Route(string startAddress, int startZip, string startCity, string endAddress, int endZip, string endCity)
        {
            this.startAddress = startAddress;
            this.startZip = startZip;
            this.startCity = startCity;
            this.endAddress = endAddress;
            this.endZip = endZip;
            this.endCity = endCity;
        }

        public string StartAddress { get { return startAddress; } set { startAddress = value;} }
        public int StartZip { get { return startZip; } set { startZip = value; } }
        public string StartCity { get { return startCity; } set { startCity = value; } }
        public int EndZip { get { return endZip; } set { endZip = value; } }
        public string EndCity { get { return endCity; } set { endCity = value; } }
    }
}
