using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{

     public enum SensorType
    {
        Thermal,
        Audio,
        Motion
    }



    internal class Sensor
    {
        public SensorType Type { get; set; }


        public Sensor() { }

        void Activate()
        {

        }






    }
}
