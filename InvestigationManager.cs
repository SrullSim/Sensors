using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class InvestigationManager
    {
        Agent agent = new Agent(RankAgentEnum.Senior_Commander);
        private static int score = 0 ;
        private int turn { get; set; } = 0;
        public InvestigationManager() { }

    // methods
    
        // run the process 
        public void runProcess()
        {
            agent.setName(UI.setName());
            while (score < agent.rankValue)
            {
                if (turn <= 10)
                {
                    //agent.ShowWeaknesses();
                    string choice = UI.menu();
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
                            score += agent.GetMatchCount("Pulse");
                            showscore();
                            break;
                        case "5":
                            score += agent.GetMatchCount("Magnetic");
                            showscore();
                            break;
                        case "6":
                            score += agent.GetMatchCount("Signal");
                            showscore();
                            break;
                        case "7":
                            score += agent.GetMatchCount("Light");
                            showscore();
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                    }
                    this.turn++;
                }
                else 
                {

                } 
            }
            
        }
        public void showscore()
        {
            Console.WriteLine($"the agent {agent.Name} revealed {score}/{agent.rankValue}");
            
        }


    }
}
