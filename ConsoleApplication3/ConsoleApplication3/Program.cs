using System;//import so dont have to type out full a class path each time
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1 // directory space
{
    class Name // class name 
    {
        static void Main(string[] args)//main method 
        {
            Console.WriteLine("\"Enter Your Name Please! \"");//Ask the user for there name
            String name = Console.ReadLine();// take in name from the screen
            Console.WriteLine("\"Hello "+ name +", Welcome to Nuig\"");// print out name and welcom to nuig
        }
    }
}
