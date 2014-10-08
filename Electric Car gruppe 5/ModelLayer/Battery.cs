using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    class Battery
    {
        private float kiloWattHours;
        private string serialNumber;

        Battery(float kiloWattHours, string serialNumber)
        {
            this.kiloWattHours = kiloWattHours;
            this.serialNumber = serialNumber;
        }

        /// <summary>
        /// Implements get and set methods for the battery object
        /// </summary>
        public float KiloWattHours { get { return kiloWattHours; } set { kiloWattHours = value; } }
        public string SerialNumber { get { return serialNumber; } set { serialNumber = value; } }
    }
}
