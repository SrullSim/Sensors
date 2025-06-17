using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class InvestigationManager
    {
        Agent agent = new Agent(RankAgentEnum.Foot_Soldier);
        private static int score = 0 ;
        private int turn { get; set; } = 0;
        //public List<SensorType> sensorTypes;
        
        // constractor 1
        public InvestigationManager() { }

    // methods
    
        public void runProcess()
        {
            Console.WriteLine("5555"+agent.rankValue);
            while(score < agent.rankValue)
            {

                string choice = UI.menu();
                this.turn++;
                switch (choice)
                {
                    case "1":
                        score += agent.GetMatchCount("Thermal");
                        showscore();
                        break;
                    case "2":
                        score += agent.GetMatchCount("Audio");
                        showscore();
                        break;
                    case "3":
                        score += agent.GetMatchCount("Motion");
                        showscore();
                        break;
                    case "4":
                        score += agent.GetMatchCount("light");
                        showscore();
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        runProcess();

                        break;
                }
            } 
        }
        public void showscore()
        {
            Console.WriteLine($"the agent {agent.Name} revealed {score}/{agent.rankValue}");
            
        }


    }
}
