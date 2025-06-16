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
            Console.WriteLine(" Thermal / Audio / Motion");

            // take choice from player
            string sensorName = Console.ReadLine();
            return sensorName;
        }

    }
}
