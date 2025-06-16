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

        private int score;

        public List<SensorType> sensorTypes;


        public InvestigationManager() { }


        public void selectionProcess(string choice)
        {
            switch (choice)
            {
                case "1":

            }
        }










        public static int setIndex(int limit)
        {
            Random random = new Random();
            return random.Next(0, limit);
        }

    }
}
