using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        

        public string HasSideCart { get; set; }


        public override void DriveAbstract()
        {
            Console.WriteLine("Drives on two wheels, 1 - 2 people, not recommended for family or personal use, unsafe...");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("The vehicle is driving");
        }
    }
}
