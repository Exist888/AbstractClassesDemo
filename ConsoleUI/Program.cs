using System;
using System.Collections.Generic;
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
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             - Create an abstract class called Vehicle
             - The vehicle class shall have three string properties: Year, Make, and Model
             ? Set the defaults of the properties to something generic in the Vehicle class
             - Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             - Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             -/

            /* 
             - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             - Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             - Provide the implementations for the abstract methods
             - Only in the Motorcycle class will you override the virtual drive method
            */

            // - Create a list of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();   //NOTE TO SELF - must use List<Type> in declaring when var not used
            
            var myFirstCar = new Car()
            {
             Make = "Honda",
             Model = "Civic",
             Year = "2015",
             HasTrunk = true,
            };
            // myFirstCar.DriveAbstract();
            // myFirstCar.DriveVirtual();
            vehicles.Add(myFirstCar);

            Vehicle mySecondCar = new Car()
            {
             Make = "Hyundai",
             Model = "Elantra",
             Year = "2017",
             HasTrunk = true,
            };
            // mySecondCar.DriveAbstract();
            // mySecondCar.DriveVirtual();
            vehicles.Add(mySecondCar);

            var myNonExistentMotorcycle = new Motorcycle()
            {
             Make = "Tomos",
             Model = "NSU-Pretis",
             Year = "1967",
             HasSideCart = false,
            };
            // myNonExistentMotorcycle.DriveAbstract();
            // myNonExistentMotorcycle.DriveVirtual();
            vehicles.Add(myNonExistentMotorcycle);

            Vehicle oldFamCar = new Car()
            {
             Make = "Yugo",
             Model = "GVC",
             Year = "1990",
             HasTrunk = true,
            };
            // oldFamCar.DriveAbstract();
            // oldFamCar.DriveVirtual();
            vehicles.Add(oldFamCar);

            foreach (var vehicleItem in vehicles)
            {
             Console.WriteLine($"{vehicleItem.Year} {vehicleItem.Make} {vehicleItem.Model}");
             vehicleItem.DriveAbstract();
             vehicleItem.DriveVirtual();
            }

            /*
             - Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes 
             - Set the properties values with object initializer syntax
             */

            /*
             - Add the 4 vehicles to the list
             - Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            //Console.ReadLine();
        }
    }
}
