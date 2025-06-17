using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    public enum RankAgentEnum
    {
        Foot_Soldier = 2,
        Pro = 3,
        Master = 4,
        Legendary = 5
    }
    internal class Agent
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Sensors { get; set; }
        private List<Sensor> Weaknesses { get; set; }
        public RankAgentEnum Rank {  get; set; }
        public int rankValue { get; set; }
        public Dictionary<SensorType, int> sensorStatus { get; set; }


        // constractor
        public Agent(RankAgentEnum rank) 
        {
            this.Rank = rank;
            rankValue = (int)Rank; 
            this.Weaknesses = AddSensorsToWeaknesses();
        }

        public void setName(string name)
        {
            this.Name = name;
        }

        // set weaknesses        
        public List<Sensor> AddSensorsToWeaknesses()
        {
            Weaknesses = new List<Sensor>();
            for (int len = 0; len < (int)Rank; len++)
            {
                Sensor sensor = new Sensor();
                sensor.Type = (SensorType)Enum.GetValues(typeof(SensorType)).GetValue(setIndex(rankValue));
                Weaknesses.Add(sensor);
            }
            return Weaknesses;
        }

        // get random number for index
        public static int setIndex(int limit)
        {
            Random random = new Random();
            return random.Next(0, limit);
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

        // set the dict we goona work on 
        public void setDictsensorStatus()
        {
            sensorStatus = new Dictionary<SensorType, int>();
            foreach(var sens in Weaknesses)
            {
                if (sensorStatus.ContainsKey(sens.Type))
                {
                    sensorStatus[sens.Type]++;
                }
                else
                {
                    sensorStatus[sens.Type] = 1;
                }
            }

        }

        public void showdict()
        {
        }
 
        //public int GetMatchCount(string sensorType)
        //{
            public int GetMatchCount(string sensorTypeIndex)
        {
            // ננסה להמיר את המחרוזת למספר
            if (!int.TryParse(sensorTypeIndex, out int index))
                return 0;

            // נבדוק אם המספר תואם לערך ב-Enum
            if (!Enum.IsDefined(typeof(SensorType), index))
                return 0;

            SensorType sensorType = (SensorType)index;

            // נחפש סנסור מתאים
            for (int i = 0; i < Weaknesses.Count; i++)
            {
                if (Weaknesses[i].Type == sensorType)
                {
                    Weaknesses.RemoveAt(i);
                    return 1;
                }
            }
            return 0;
        }





    }
}
