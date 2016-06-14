
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Michael Curley Assignment4 14231371
namespace ConsoleApplication5
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = 1000;
            Console.WriteLine("Test main");

            //creating a list for testing
            List<Vehicle> l1 = new List<Vehicle>();//vehicle the base class car and motorcycle class derived class 
            l1.Add(new Car(4, 4, 4, 2500));
            l1.Add(new MotorCycle(0, 2, 3, 1500));
            l1.Add(new Car(5, 7, 4, 25000));
            l1.Add(new MotorCycle(0, 1, 2, 500));
            l1.Add(new Car(3, 2, 4, 4500));
            l1.Add(new MotorCycle(0, 2, 3, 2500));
            l1.Add(new Car(4, 5, 4, 15000));
            l1.Add(new MotorCycle(0, 2, 1, 1200));


            Console.WriteLine("\n\n\n");
            Console.WriteLine("Unsorted List");
            Console.WriteLine("\n");
            foreach (var element in l1)//print out unsorted list or contents of list
            {
                Console.WriteLine(element);
            }

            l1.Sort();//Call Compare Method

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Sorted by value and then by type");
            Console.WriteLine("\n");
            foreach (var element in l1)//print out sorted list by Value and then by Type type a built in method
            {
                Console.WriteLine(element);
            }

        }
    }
}


