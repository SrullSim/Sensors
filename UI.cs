﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal static class UI
    {


        public static string setName()
        {
            Console.WriteLine("enter the agent name");
            string name = Console.ReadLine();
            if(name != null || name.All(char.IsLetter))
            {
                return name;
            }
            else
            {
                Console.WriteLine("Invalid name, please try again");
                return "";
            }
        }



        // This method displays the menu and returns the user's choice
        public static string menu()
        {
            Console.WriteLine("======= Welcome to Game Investigation ======= ");
            Console.WriteLine("please enter the sensor type");
            Console.WriteLine("1.Thermal \n2.Audio \n3.Motion \n4.Pulse \n5.Magnetic \n6.Signal \n7.Light ");

            // take choice from player
            string sensorName = Console.ReadLine();
            return sensorName;
        }



    }
}
