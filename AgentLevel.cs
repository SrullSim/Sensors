using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sensors.sensorsTypes;

namespace Sensors
{

    public enum RankAgentEnum
    {
        Foot_Soldier = 2,
        Squad_Leader = 4,
        Senior_Commander = 6,
        Organization_Leader = 8
    }
    internal class AgentLevel
    {

        public static (RankAgentEnum nextRank, bool hasChanged) GetNextRank( RankAgentEnum rank)
        {
            int nextValue = (int)rank + 2;

            if (Enum.IsDefined(typeof(RankAgentEnum), nextValue))
            {
                return ((RankAgentEnum)nextValue, true);
            }
            else
            {
                // אין דרגה גבוהה יותר, מחזיר את הדרגה הנוכחית
                return (rank, false);
            }
        }


    }


}
