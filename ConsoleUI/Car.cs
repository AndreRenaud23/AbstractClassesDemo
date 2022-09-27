using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public string HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Four wheel drive, 2 - 8 people, recommended for family and personal use, safest driving...");
        }


    }
}
