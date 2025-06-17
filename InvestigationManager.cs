using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class InvestigationManager
    {
        Agent agent = new Agent(RankAgentEnum.Bginer);

        private static int score = 0 ;

        public List<SensorType> sensorTypes;


        public InvestigationManager() { }


        public void processSelection()
        {
            while(score < agent.Rank)
            {
                //Console.Clear();
                string choice = UI.menu();
                switch (choice)
                {
                    case "1":
                        score += agent.GetMatchCount(choice);
                        showscore();
                        agent.ShowWeaknesses();
                        break;

                    case "2":
                        score += agent.GetMatchCount(choice);
                        showscore();
                        agent.ShowWeaknesses();

                        break;
                    case "3":
                        score += agent.GetMatchCount(choice);
                        showscore();
                        agent.ShowWeaknesses();

                        break;
                    case "4":
                        score += agent.GetMatchCount(choice);
                        showscore();
                        agent.ShowWeaknesses();

                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        processSelection();

                        break;
                }
            } 
        }


        public void showscore()
        {
            Console.WriteLine($"the agent {agent.Name} revealed {score}/{agent.Rank}");
        }









        public static int setIndex(int limit)
        {
            Random random = new Random();
            return random.Next(0, limit);
        }

    }
}
