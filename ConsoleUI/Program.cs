using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion



            List<Vehicle> vehicles = new List<Vehicle>();

            Car car = new Car() {Year = "2022", Make = "Tesla", Model = "Model 3", HasTrunk = "Yes"};
            Motorcycle motorcycle = new Motorcycle() { Year = "2023", Make = "Harley-Davidson", Model = "Road King", HasSideCart = "Yes" };
            

            Vehicle motorcycle2 = new Motorcycle() { Year = "2000", Make = "Harley-Davidson", Model = "XLH Sportster® 883", HasSideCart = "No" };
            Vehicle car2 = new Car() { Year = "2023", Make = "Chevrolet", Model = "Tahoe", HasTrunk = "Yes" };
            
            Car car3 = new Car() { Year = "2014", Make = "Honda", Model = "Hatchback", HasTrunk = "Yes" };
            Motorcycle motorcycle3 = new Motorcycle() { Year = "2020", Make = "Yamaha", Model = "Model YZF-R6", HasSideCart = "No" };


            vehicles.Add(car);
            vehicles.Add(motorcycle);
            vehicles.Add(car2);
            vehicles.Add(motorcycle2);
            vehicles.Add(car3);
            vehicles.Add(motorcycle3);



            foreach (var vehicle in vehicles)
            {

                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                Console.WriteLine(vehicle.Year);
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine();

            }



        }
    }
}
