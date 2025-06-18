using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors.sensorsTypes
{
    internal class AudioSensor: Sensor
    {
        public sensorTypeEnum Type { get; set; }

        public AudioSensor(sensorTypeEnum type) 
        {
            Type = type;
        }


        void Activate()
        {

        }
    }
}
