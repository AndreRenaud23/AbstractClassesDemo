using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "2000";
        public string Make { get; set; }
        public string Model { get; set; }

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Car Driving Virtual Status...");
        }

    }
}
