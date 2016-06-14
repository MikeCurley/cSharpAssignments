using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);
            numbers.Add(12);
            numbers.Add(14);

            int x=numbers.Count;

            Console.WriteLine("Count "+x);


            foreach(int i in numbers){
                Console.WriteLine(i);
            
            }
        }
    }
}
