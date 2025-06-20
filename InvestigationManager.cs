using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class InvestigationManager
    {
        Agent agent = new Agent(RankAgentEnum.Squad_Leader);
        private bool isGameOver = false;
        private RankAgentEnum AgentRank;
        private int score = 0 ;
        private int turn { get; set; } = 0;
        public InvestigationManager() 
        {
            this.AgentRank = agent.getRank();
        }

    // methods
    
        // run the process 
        public void runProcess()
        {
            agent.setName(UI.setName());
            //agent.showdict();
            //agent.ShowWeaknesses();

            do
            {
                if (turn <= 10)
                {
                    // display the menu 
                    string choice = UI.menu();

                    // process the choice
                    processing(choice);

                    // count turns
                    this.turn++;
                }
                else
                {
                    restart();
                }
                if (this.score >= agent.rankValue)
                {
                    // set level up
                    var (nextRank, hasChanged) = AgentLevel.GetNextRank(agent.getRank());

                    // restart the agent
                    restart();
                    this.agent.setRankValue((int)agent.getRank()); 
                    // checked if chenge or finish the game
                    if (hasChanged)
                    {
                        agent.setRank(nextRank);
                        Console.WriteLine($"התקדמת לדרגה: {nextRank}");
                        this.score = 0;
                        this.turn = 0;
                    }
                    else
                    {
                        Console.WriteLine("הגעת לדרגה הגבוהה ביותר!");
                        this.isGameOver = true;
                    }
                    
                }

            }
            while (!isGameOver);

        }
        public void showscore()
        {
            Console.WriteLine($"the agent {agent.Name} revealed {score}/{agent.rankValue}");
            
        }
        public void restart()
        {
            Console.WriteLine("you have played 10 turns start over again");
            //Console.WriteLine("turns before: " + turn);
            agent.clearWeaknesses();
            agent.AddSensorsToWeaknesses();
            agent.clearAttachedList();
            this.turn = 0;
            this.score = 0;
            //Console.WriteLine("turns after: " + turn);

            Console.WriteLine("press any key to conntinue...");
            Console.ReadKey();
        }

        // process the choice
        public void processing(string choice)
        {
            switch (choice)
            {
                case "1":
                    this.score += this.agent.GetMatchCount("Thermal");
                    this.agent.AddSensorToAttach("Thermal");
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
                    agent.AddSensorToAttach("Signal");        

                    break;

                case "7":
                    score += agent.GetMatchCount("Light");
                    showscore();
                    agent.AddSensorToAttach("Ligth");
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

    }
}
