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
        public List<Sensor> Sensors { get; set; }
        private List<string> Weaknesses { get; set; }



        public Agent() { }

        public string GetMatchCount()
        {
            return "";
        }

        public enum MyEnum { Value1, Value2, Value3, Value4 }

        private static Random rnd = new Random();

        public static MyEnum GetRandomEnumValue()
        {
            var values = Enum.GetValues(typeof(MyEnum));
            return (MyEnum)values.GetValue(rnd.Next(values.Length));
        }







    }
}
