using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    //Properties - Year, Make, Model
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    
    //Abstract Method called DriveAbstract with no implementation
    public abstract void DriveAbstract();
    
    //Virtual Method called DriveVirtual with base implementation
    public virtual void DriveVirtual()
    {
        Console.WriteLine("Vehicle is driving.");
        Console.WriteLine("______________________________");
    }

}