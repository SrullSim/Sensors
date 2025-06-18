using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors.sensorsTypes
{
    internal class ThermalSensor:Sensor
    {
        public sensorTypeEnum Type { get; set; }
        public int? Disability { get; set; }

        // constractor
        public ThermalSensor(sensorTypeEnum type) 
        {
            Type = type;
        }

        //sensorTypeEnum Activate(List<Sensor> Weaknesses)
        
    }
}
