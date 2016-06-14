using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Michael Curley Assignment4 14231371
namespace ConsoleApplication5
{
    class Vehicle : IComparable<Vehicle>
    {
        //protected data fields so that sub-classes or derived classes can have access to them
        protected int doors = 0;
        protected int seats = 0;
        protected int wheels = 0;
        protected int value = 0;
        public Vehicle()
        {
            Console.WriteLine("Vehicle Constructor");
            doors = 4;
            seats = 4;
            wheels = 4;
            value = 0;
        }

        public int Doors//setter-getter for Doors
        {
            set
            {
                doors = value;
            }
            get
            {
                return doors;
            }

        }
        public int Seats//setter-getter for Seats
        {
            set
            {
                seats = value;
            }
            get
            {
                return seats;
            }

        }
        public int Wheels//setter-getter for wheels
        {
            set
            {
                wheels = value;
            }
            get
            {
                return wheels;
            }
        }
        public int Value//setter-getter for Value
        {

            set
            {
                this.value = value;
            }
            get
            {

                return value;
            }
        }


        public virtual void driving()//
        {
            Console.WriteLine(" I AM DRIVING A VEHICLE");
        }

        public virtual void display()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Vehicle Class");
            Console.WriteLine("No of Doors  " + doors);
            Console.WriteLine("No of Seats  " + seats);
            Console.WriteLine("No of Wheels " + wheels);
            Console.WriteLine("VALUE        " + value);
            Console.WriteLine("\n\n");

        }
        // CompareTo method for sorting sort by price and then by type
        public int CompareTo(Vehicle v)
        {
            if (this.Value < v.Value)
                return 1;
            else if (this.Value > v.Value)
                return -1;
            else
            {
                return this.GetType().Name.CompareTo(v.GetType().Name) ;
            }
        }


        public override string ToString()
        {
            // String representation.
            return this.GetType().Name+",\t\t\t\t     "+this.Value.ToString();
        }

    }
}
