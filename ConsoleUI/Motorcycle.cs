using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    //Distinct property for child class Motorcycle
    public bool HasSideCart { get; set; }
    
    //Implementation of Abstract Method
    public override void DriveAbstract()
    {
        Console.WriteLine("Motorcycle is driven by steering with handle bars,\n" +
                          "twisting handle to accelerate, and clenching lever on handle to brake.");
        HasSideCartPrint();
    }
    
    //Override DriveVirtual in Motorcycle class only
    public override void DriveVirtual()
    {
        Console.WriteLine("Motorcycle is driving.");
        Console.WriteLine("____________________________");
    }
    
    //Method to print HasSideCart or no
    public void HasSideCartPrint()
    {
        if (HasSideCart)
        {
            Console.WriteLine("This motorcycle has a Side Cart.");
        }
        else
        {
            Console.WriteLine("This motorcycle has no Side Cart.");
        }
    }
}