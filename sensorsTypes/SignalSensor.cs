using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors.sensorsTypes
{
    internal class SignalSensor:Sensor
    {
        public sensorTypeEnum Type { get; set; }



        public SignalSensor(sensorTypeEnum type)
        {
            Type = type;
        }

        // activate
        public string Activate(Agent agent)
        {
            return agent.getStringRank();
        }
    }
}
