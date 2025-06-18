using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors.sensorsTypes
{
    internal class LightSensor : Sensor
    {

        public sensorTypeEnum Type { get; set; }



        public LightSensor(sensorTypeEnum type)
        {
            Type = type;
        }


        // activate
        public string Activate(Agent agent)
        {
            string agentDetails ="agent details: \n  name - " + agent.Name + " \n  Rank - " + agent.getRank();
            return agentDetails;
        }
         
    }
}
