using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Vehicle
    {
        //protected data fields so that sub-classes or derived classes can have access to them
        protected int doors = 0;
        protected int seats = 0;
        protected int wheels = 0;

        public Vehicle() {
            Console.WriteLine("Vehicle Constructor");
            doors = 4;
            seats = 4;
            wheels = 4;

        }

        public int Doors {
            set {
                doors = value;
            }
            get {
                return doors;
            }
        
        }
        public int Seats {
            set {
                seats = value;
            }
            get {
                return seats;
            }

        }
        public int Wheels {
            set {
                wheels = value;
            }
            get {
                return wheels;
            }
        }
        public virtual void driving() {
            Console.WriteLine(" I AM DRIVING A VEHICLE");
        }

        public virtual void display()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Vehicle Class");
            Console.WriteLine("No of Doors  " + doors);
            Console.WriteLine("No of Seats  " + seats);
            Console.WriteLine("No of Wheels " + wheels);
            Console.WriteLine("\n\n");

        }

    }
}
