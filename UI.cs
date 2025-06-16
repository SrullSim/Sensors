using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal static class UI
    {


        // This method displays the menu and returns the user's choice
        public static string menu()
        {
            Console.Clear();
            Console.WriteLine("======= Welcome to Game Investigation ======= ");
            Console.WriteLine("please enter the sensor type");
            Console.WriteLine("1.Thermal \n2.Audio \n3.Motion \n4.light");

            // take choice from player
            string sensorName = Console.ReadLine();
            return sensorName;
        }

    }
}
