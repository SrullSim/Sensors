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
        public int NumOfSensors {  get; set; }


        public Agent() 
        {
            NumOfSensors = Weaknesses.Count();
            AddSensorsToWeaknesses();
        }

        public int GetMatchCount(string sensorType)
        {
            
            foreach (var sensor in Weaknesses)
            {
                if (sensor.Type.ToString() == sensorType)
                {
                    Weaknesses.Remove(sensor);
                    return 1;
                }
            }
            return 0;
        }

        
        public void AddSensorsToWeaknesses()
        {
            for(int len = 0; len < NumOfSensors; len++)
            {
                Sensor sensor = new Sensor();
                sensor.Type = (SensorType)Enum.GetValues(typeof(SensorType)).GetValue(setIndex(NumOfSensors));
                Weaknesses.Add(sensor);

            }
            SensorType selected = (SensorType)Enum.GetValues(typeof(SensorType)).GetValue(1);
        }


        public static int setIndex(int limit)
        {
            Random random = new Random();
            return random.Next(0, limit);
        }





    }
}
