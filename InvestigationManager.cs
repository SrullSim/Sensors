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
        public InvestigationManager() { }

    // methods
    
        // run the process 
        public void runProcess()
        {
            agent.setName(UI.setName());
            //agent.showdict();
            while (score < agent.rankValue)
            {
                if (turn <= 10)
                {
                    string choice = UI.menu();
                    
                    switch (choice)
                    {
                        case "1":
                            score += agent.GetMatchCount("Thermal");
                            agent.AddSensorToAttach("Thermal");
                            showscore();          
                            break;
                        case "2":
                            score += agent.GetMatchCount("Audio");
                            showscore();
                            agent.AddSensorToAttach("Audio");
                            break;
                        case "3":
                            score += agent.GetMatchCount("Motion");
                            showscore();
                            agent.AddSensorToAttach("Motion");
                            break;
                        case "4":
                            score += agent.GetMatchCount("Pulse");
                            showscore();
                            agent.AddSensorToAttach("Pulse");
                            break;
                        case "5":
                            score += agent.GetMatchCount("Magnetic");
                            showscore();
                            agent.AddSensorToAttach("Magnetic");
                            break;
                        case "6":
                            score += agent.GetMatchCount("Signal");
                            showscore();
                            agent.AddSensorToAttach("signal");
                            break;
                        case "7":
                            score += agent.GetMatchCount("Light");
                            showscore();
                            agent.AddSensorToAttach("Light");
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
