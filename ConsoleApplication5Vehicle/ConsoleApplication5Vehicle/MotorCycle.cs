using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class MotorCycle:Vehicle
    {
         public MotorCycle() {
            Console.WriteLine("MotorCycle Constructor");
            doors = 0;
            seats = 1;
            wheels = 2;
        }
        public new void driving()
        {
            Console.WriteLine(" I AM DRIVING A MOTORCYCLE");
        }
        public override void display()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("MotorCycle Class");
            Console.WriteLine("No of Doors  " + doors);
            Console.WriteLine("No of Seats  " + seats);
            Console.WriteLine("No of Wheels " + wheels);
            Console.WriteLine("\n\n");

        }


    }
}
