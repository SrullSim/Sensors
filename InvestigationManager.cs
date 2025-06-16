using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class InvestigationManager
    {
        Agent agent = new Agent();

        private static int score = 0 ;

        public List<SensorType> sensorTypes;


        public InvestigationManager() { }


        public void selectionProcess(string choice)
        {
            switch (choice)
            {
                case "1":
                    score += agent.GetMatchCount(choice);
                    showscore();

                    break;
            }
        }

        public void showscore()
        {
            Console.WriteLine($"the agent {agent.Name} revealed {score}/{agent.NumOfSensors}");
        }









        public static int setIndex(int limit)
        {
            Random random = new Random();
            return random.Next(0, limit);
        }

    }
}
