using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sensors.sensorsTypes;

namespace Sensors
{
    
    internal class Agent
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> attachedSensors { get; set; }
        private List<Sensor> Weaknesses { get; set; }
        private RankAgentEnum Rank { get; set; }
        public int rankValue { get; set; }
        public Dictionary<string, int> sensorStatus { get; set; } 


        // constractor
        public Agent(RankAgentEnum rank)
        {
            this.Rank = rank;
            this.rankValue = (int)Rank;
            this.Weaknesses = AddSensorsToWeaknesses();
            this.sensorStatus = setDictsensorStatus();
        }

        // set name
        public void setName(string name)
        {
            this.Name = name;
        }

        // set weaknesses        
        public List<Sensor> AddSensorsToWeaknesses()
        {
            Weaknesses = new List<Sensor>();
            for (int sensors = 0; sensors < rankValue; sensors++)
            {
                sensorTypeEnum sensorType = (sensorTypeEnum)Enum.GetValues(typeof(sensorTypeEnum)).GetValue(4);
                

                Sensor sensor = FactoryOfSensors.CreateSensor(sensorType);
                //sensor = (sensorTypeEnum)Enum.GetValues(typeof(sensorTypeEnum)).GetValue(getIndex(rankValue));
                Weaknesses.Add(sensor);
            }
            return Weaknesses;
        }

        // add sensor to attached Sensors
        public void AddSensorToAttach(string sensorType)
        {
            attachedSensors.Add(sensorType);
        }

        // remove sensor from attachedSensors
        public void RMSensorFromattachedSensors(string sensorType)
        {
            attachedSensors.Remove(sensorType); 
        }

        // get rank of agent for attack
        public string getRank()
        {
            return this.Rank.ToString();
        }


        // get random number for index
        public static int getIndex(int limit)
        {
            Random random = new Random();
            return random.Next(0, limit);
        }
        
        // set the dict we goona work on 
        public Dictionary<string,int> setDictsensorStatus()
        {
            Dictionary<string, int> setdict = new Dictionary<string, int>();
            foreach (var sens in Weaknesses)
            {
                if (setdict.ContainsKey(sens.Type.ToString()))
                {
                    setdict[sens.Type.ToString()]++;
                }
                else
                {
                    setdict[sens.Type.ToString()] = 1;
                }
            }
            return setdict;

        }

        // check the dictionary
        public int GetMatchCount(string sensorType)
                {
                    foreach(KeyValuePair<string, int> sens in sensorStatus)
                    {
                        if (sens.Key == sensorType && sensorStatus[sens.Key] > 0)
                        {
                            sensorStatus[sens.Key] -= 1;
                            return 1;
                        }
                    }
                    return 0;
                }


        // testing
        public void showdict()
        {
                foreach (KeyValuePair<string, int> sens in sensorStatus)
                {
                    Console.WriteLine(sens.Key.ToString());
                    Console.WriteLine(sens.Value.ToString());
                }
        }

        // for testing
        public void ShowWeaknesses()
        {
            Console.WriteLine("Agent Weaknesses:");
            foreach (var sensor in Weaknesses)
            {
                Console.WriteLine(sensor.Type);
            }
        }


        


        }
}
