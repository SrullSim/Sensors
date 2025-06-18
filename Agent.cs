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
        public RankAgentEnum Rank { get; set; }
        public int rankValue { get; set; }
        public Dictionary<string, int> sensorStatus { get; set; } 


        // constractor
        public Agent(RankAgentEnum rank)
        {
            this.Rank = rank;
            rankValue = (int)Rank;
            this.Weaknesses = AddSensorsToWeaknesses();
            this.sensorStatus = setDictsensorStatus();
        }

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
                Sensor sensor = new Sensor();
                sensor.Type = (@string)Enum.GetValues(typeof(@string)).GetValue(setIndex(rankValue));
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
                    Console.WriteLine("add key " + sens.Type );
                }
            }
            return setdict;

        }

        public void showdict()
        {
            if (sensorStatus != null)
            {
                Console.WriteLine("get in dict");
                foreach (KeyValuePair<string, int> sens in sensorStatus)
                {
                    Console.WriteLine(sens.Key.ToString());
                    Console.WriteLine(sens.Value.ToString());
                    Console.WriteLine("dicttt");
                }
           }
            else
            {
                Console.WriteLine("error :  not dict found" );
            }
            }


        //public int GetMatchCount(string sensorType)
        //{
        //    for (int i = 0; i < Weaknesses.Count; i++)
        //    {
        //        if (Weaknesses[i].Type.ToString() == sensorType)
        //        {
        //            return 1;
        //        }
        //    }
        //    return 0;
        //}


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


        }
}
