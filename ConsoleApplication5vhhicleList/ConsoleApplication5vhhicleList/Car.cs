using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Michael Curley Assignment4 14231371
namespace ConsoleApplication5
{
    class Car : Vehicle // car inherits from base class vehicle
    {


        private bool automatic = true;

        public Car()//car constructor
        {
            Console.WriteLine("Car Constructor");
            doors = 4;
            seats = 4;
            wheels = 4;

        }
        public Car(int d, int s, int w, int v)//car constructor
        {
            Console.WriteLine("Car Constructor");
            doors = d;
            seats = s;
            wheels = w;
            value = v;

        }
        public bool Automatic//getter-setter method for automatic car
        {
            set
            {
                automatic = value;
            }
            get
            {
                return automatic;
            }

        }
        public void CheckAutomatic()//if car automatic pritn this out if not print that out 
        {
            if (Automatic == true)
            {
                Console.WriteLine("This Car is Automatice");
            }
            else if (Automatic == false)
            {
                Console.WriteLine("This Car is Not Automatice");
            }

        }

        public new void driving()//not overrriding method
        {
            Console.WriteLine(" I AM DRIVING A CAR");
        }

        public override void display()//overrriding method
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Car Class");
            Console.WriteLine("No of Doors  " + doors);
            Console.WriteLine("No of Seats  " + seats);
            Console.WriteLine("No of Wheels " + wheels);
            Console.WriteLine("VALUE        " + value);
            Console.WriteLine(Automatic);
            CheckAutomatic();
            Console.WriteLine("\n\n");

        }
    }
}
