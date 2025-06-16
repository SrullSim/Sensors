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
        public List<Sensor> Sensors { get; set; }
        private List<string> Weaknesses { get; set; }



        public Agent() { }

        public int GetMatchCount(string choice)
        {
            foreach (var sensor in Sensors)
            {
                if (sensor.Type.ToString() == choice)
                {
                    return 1;
                }
            }


            return 1;
        }

        







    }
}
