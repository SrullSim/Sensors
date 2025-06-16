using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Agent
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Sensors { get; set; }
        private List<Sensor> Weaknesses { get; set; }



        public Agent() { }

        public int GetMatchCount(string sensorType)
        {
            foreach (var sensor in Weaknesses)
            {
                if (sensor.Type.ToString() == sensorType)
                {
                    return 1;
                }
            }


            return 0;
        }

        
        public void AddSensor(string selectedSensor)
        {

        }






    }
}
