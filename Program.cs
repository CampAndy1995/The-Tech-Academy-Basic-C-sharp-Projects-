using System;

namespace MyApplication
{
    class Vehicle  // Base class (parent) 
    {
        public virtual void vehiclemake()
        {
            Console.WriteLine("The vehicle comes in a 4WD option");
            Console.ReadLine();
        }
    }

    class Chevy : Vehicle  // Derived class (child) 
    {
        public override void vehiclemake()
        {
            Console.WriteLine("This Vehicle company was onced Headquartered in Connecticut");
            Console.ReadLine();
        }
    }

    class Ford : Vehicle  // Derived class (child) 
    {
        public override void vehiclemake()
        {
            Console.WriteLine("This Vehicle company has always been Headquartered in Detroit, Michigan.");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle();  // Create a Vehicle object
            Vehicle myChevy = new Chevy();  // Create a Chevy object
            Vehicle myFord = new Ford();  // Create a Ford object

            myVehicle.vehiclemake();
            myChevy.vehiclemake();
            myFord.vehiclemake();
        }
    }
}
