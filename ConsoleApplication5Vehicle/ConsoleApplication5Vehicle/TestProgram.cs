using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = 1000;
            Console.WriteLine("Test main");

            //create 3 objects
            Vehicle v = new Vehicle();
            Car c = new Car();
            MotorCycle m = new MotorCycle();
            //display objects
            v.display();
            c.display();
            m.display();

            //set car attributes
            c.Doors = 4;
            c.Seats = 5;
            c.Wheels = 4;
            c.Automatic = false;
            c.display();
            //set motorBike attributes
            m.Doors = 0;
            m.Seats = 2;
            m.Wheels = 2;
            m.display();



            //using a reference of vehicle and initilise with car as car (is-a) vehicle polmorphic call
            Console.WriteLine("NEW V1 VEHICLE REFERENCE");
            Vehicle v1 = new Car();//downside with this is you dont have access to automatic datafield
            v1.display();//calling the overriding method in the derived class car
            v1.driving();//canceling the overiding and so calling the reference method in vehicle
            Console.WriteLine("\n");
            Console.WriteLine("NEW V2 VEHICLE REFERENCE");
            Vehicle v2 = new MotorCycle();// creating a object of MotroCycle
            v2.Doors = 0;//set motorBike attributes
            v2.Seats = 3;
            v2.Wheels = 3;
            v2.display();//calling the overriding method in the derived class MotorCycle
            v2.driving();//canceling the overiding and so calling the reference method in vehicle

            MotorCycle m2 = new MotorCycle();// creating a object of MotroCycle
            m2.driving();//calling the method driving in the MotorCycle class
            
        }
    }
}
