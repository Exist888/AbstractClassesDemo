using System;
using System.Collections.Generic;

namespace ConsoleUI;

public class Car : Vehicle
{
    //Distinct property for child class Car
    public bool HasTrunk { get; set; }
    
    //Implementation of Abstract Method
    public override void DriveAbstract()
    {
        Console.WriteLine("Car is driven by using a steering wheel, gas and brake pedals,\n" +
                          "and sometimes a stick shift to change gears.");
        HasTrunkPrint();
    }
    
    //Method to Print HasTrunk or no
    public void HasTrunkPrint()
    {
        if (HasTrunk)
        {
            Console.WriteLine("This car has a trunk.");
        }
        else
        {
            Console.WriteLine("This car has no trunk.");
        }
    }

}