using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Michael Curley Assignment4 14231371
namespace ConsoleApplication5
{
    class MotorCycle : Vehicle //MotorCycle inherits from base class vehicle
    {
        public MotorCycle() //MotorCycle constructors
        {
            Console.WriteLine("MotorCycle Constructor");
            doors = 0;
            seats = 1;
            wheels = 2;
        }
        public MotorCycle(int d, int s, int w, int v)//MotorCycle constructors
        {
            Console.WriteLine("Car Constructor");
            doors = d;
            seats = s;
            wheels = w;
            value = v;
        }
        public new void driving()//new method wont override
        {
            Console.WriteLine(" I AM DRIVING A MOTORCYCLE");
        }
        public override void display()//override method display
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("MotorCycle Class");
            Console.WriteLine("No of Doors  " + doors);
            Console.WriteLine("No of Seats  " + seats);
            Console.WriteLine("No of Wheels " + wheels);
            Console.WriteLine("VALUE        " + value);
            Console.WriteLine("\n\n");

        }
    }
}


