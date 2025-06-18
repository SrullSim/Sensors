using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{

     public enum @string
    {
        Thermal,
        Audio,
        Motion,
        Pulse,
        Magnetic,
        Signal,
        Light
    }



    internal class Sensor
    {
        public @string Type { get; set; }


        public Sensor() { }

        void Activate()
        {

        }






    }
}
