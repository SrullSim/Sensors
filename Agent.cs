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
        private static readonly Random rnd = new Random();

        // constractor
        public Agent(RankAgentEnum rank)
        {
            this.Rank = rank;
            this.rankValue = (int)Rank;
            this.Weaknesses = AddSensorsToWeaknesses();
            this.sensorStatus = setDictsensorStatus();
            this.attachedSensors = new List<string>();
        }

        // set name
        public void setName(string name)
        {
            this.Name = name;
        }

        //set weaknesses
        public List<Sensor> AddSensorsToWeaknesses()
        {
            this.Weaknesses = new List<Sensor>();
            for (int sensors = 0; sensors < rankValue; sensors++)
            {
                // get random sensor type based on rank value
                sensorTypeEnum sensorType = getRand();

                // create sensor object using factory method
                Sensor sensor = FactoryOfSensors.CreateSensor(sensorType);

                // add sensor to weaknesses list
                this.Weaknesses.Add(sensor);
            }
            return this.Weaknesses;
        }

        // clear weaknesses
        public void clearWeaknesses()
        {
            Weaknesses.Clear();
        }

        // clear attached sensor
        public void clearAttachedList()
        {
            attachedSensors.Clear();
        }

        // add sensor to attached Sensors
        public void AddSensorToAttach(string sensorType)
        {
            foreach (KeyValuePair<string, int> sens in sensorStatus)
            {
                if (sens.Key == sensorType && sensorStatus[sens.Key] > 0)
                {
                    attachedSensors.Add(sensorType);
                }
            }
        }

        // remove sensor from attachedSensors
        public void RMSensorFromattachedSensors(string sensorType)
        {
            attachedSensors.Remove(sensorType);
        }

        // get rank of agent for attack
        public string getStringRank()
        {
            return this.Rank.ToString();
        }


        // get random number for index
        public static int getIndex(int limit)
        {
            int num = rnd.Next(0, limit);
            Console.WriteLine("num undex" + num);
            return num;
        }

        // set the dict we goona work on 
        public Dictionary<string, int> setDictsensorStatus()
        {
            Dictionary<string, int> dictStatus = new Dictionary<string, int>();
            foreach (var sens in this.Weaknesses)
            {
                if (dictStatus.ContainsKey(sens.Type.ToString()))
                {
                    dictStatus[sens.Type.ToString()]++;
                }
                else
                {
                    dictStatus[sens.Type.ToString()] = 1;
                }
            }
            return dictStatus;

        }

        // check the dictionary
        public int GetMatchCount(string sensorType)
        {
            foreach (KeyValuePair<string, int> sens in sensorStatus)
            {
                if (sens.Key == sensorType && sensorStatus[sens.Key] > 0)
                {
                    sensorStatus[sens.Key] -= 1;
                    return 1;
                }
            }
            return 0;
        }

        // get rank 
        public RankAgentEnum getRank()
        {
            return this.Rank;
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



        public sensorTypeEnum getRand()
        {
            
            Array enumValues = Enum.GetValues(typeof(sensorTypeEnum));

            
            int index = getIndex(rankValue);

            object enumValueObj = enumValues.GetValue(index);

            //sensorTypeEnum sensorType = (sensorTypeEnum)enumValueObj;

            if (index < 0 || index >= enumValues.Length)
                throw new ArgumentOutOfRangeException("index", "Index out of range for sensorTypeEnum");

            sensorTypeEnum sensorType = (sensorTypeEnum)enumValues.GetValue(index);

            return sensorType;
        }

    }
}
