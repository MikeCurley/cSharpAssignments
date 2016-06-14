using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Car:Vehicle
    {


        private bool automatic = true;

        public Car() {
            Console.WriteLine("Car Constructor");
            doors = 4;
            seats = 4;
            wheels = 4;
        
        }

        public bool Automatic {
            set{
                automatic  = value;
            }
            get
            {
                    return automatic;   
            }
        
        }
        public void CheckAutomatic() {
            if(Automatic==true){
                Console.WriteLine("This Car is Automatice");
            }else if(Automatic==false){
                Console.WriteLine("This Car is Not Automatice");
            }
        
        }
      
        public new void driving()
        {
            Console.WriteLine(" I AM DRIVING A CAR");
        }

        public override void display()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Car Class");
            Console.WriteLine("No of Doors  " + doors);
            Console.WriteLine("No of Seats  " + seats);
            Console.WriteLine("No of Wheels " + wheels);
            Console.WriteLine(Automatic);
            CheckAutomatic();
            Console.WriteLine("\n\n");

        }
    }
}
