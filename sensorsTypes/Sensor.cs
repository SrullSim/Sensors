using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors.sensorsTypes
{

    public enum sensorTypeEnum
    {
        
        Audio,
        Thermal, 
        Motion,
        Pulse,
        Magnetic,
        Signal,
        Light
    }
    internal abstract class Sensor
    {
        public sensorTypeEnum Type { get; set; }
        public int? Disability { get; set; }

        // constractor
        public Sensor() { }

        void Activate()
        {

        }
    }
}
