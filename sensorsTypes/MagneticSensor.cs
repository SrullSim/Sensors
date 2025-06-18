using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors.sensorsTypes
{
    internal class MagneticSensor : Sensor
    {

        public sensorTypeEnum Type { get; set; }



        public MagneticSensor(sensorTypeEnum type)
        {
            Type = type;
        }
    }
}
