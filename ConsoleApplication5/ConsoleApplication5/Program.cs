using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public delegate int calculation(int x,int y);
    public delegate void display();


    struct test {

       int y;

        public int T {

            set {
                y = value;
            
            }
            get {
                return y;
            }

        }
    
    }

  

    class Program :Father,IHello,IGoodBye
    {

        private int number = 10;
        private String name="mike";
        private int number2 = 500;
       


         void IHello.display() {

             Console.WriteLine("Hello");
        }
         void IGoodBye.display() {
             Console.WriteLine("Good Bye");        
        }

        public int Number {

            set {
                number = value;
            
            }
            get
            {
                return number;
            }
        }

        public String Name {
            set {
                name = value;
            }
            get {
                return name;
            }
        
        }

        public int Number2{

            get {
                return number2;
            }
        }

        public int add(int x, int y)
        {
            int z = x + y;
            return z;
        }

        public  void display12() {
            Console.WriteLine("display");
        }
        public static void display13()
        {
            Console.WriteLine("display kjjjjjjjjjjjjjllhklllllllll");
        }

        public int subtract(int x, int y)
        {
            int z = x - y;
            return z;
        }
        


        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("value of X  "+x);
            Program p = new Program();
            Father f = new Father();
            Father f1 = new Program();
            test t= new test();
            t.T = 1000;
            Console.WriteLine("struct t =    "+t.T);
            const int xx=100;
            int gg = 0;

            int result1 = 10 + xx;
            Console.WriteLine(result1);
            Console.WriteLine(result1 = xx + 7);
            gg++;

            p.outTest(out x);
            Console.WriteLine("value of X after out is " + x);
            p.refTest(ref x);
            Console.WriteLine("value of X after ref is " + x);
            p.passTest(x);
            Console.WriteLine("value of X after pass is " + x);

            p.Number = 1500;
            p.Name = "John";

            Console.WriteLine("Number is "+p.Number);

            Console.WriteLine("Name is " + p.Name);

            //p.Number2 = 900;
            Console.WriteLine("Number2  is " + p.number2);
     
            calculation c=p.add;//associate the delegate to the method add
            display d=p.display12;
            int result =c(8,5);
            Console.WriteLine("result of add is "+result);
            Console.WriteLine();
            c = p.subtract;
            result = c(10,1);
            Console.WriteLine("result of substraction "+result);

            display d2 = new display(display13);
            d2();


            f.print();
            p.print();
            f1.print();


            List<String> array = new List<String>();
            array.Add("A");
            array.Add("B");
            array.Add("C");
            array.Add("D");
            array.Add("E");
            array.Add("F");
            array.Add("G");
            array.Add("H");

            array.Remove("G");
            array.Reverse();


            foreach(String letter in array){
                Console.WriteLine(letter);
            }
            IHello I = new Program();
            IGoodBye g = new Program();

            I.display();
            g.display();



        }

        public void outTest(out int d) {
            d = 50;
        }
        public void refTest(ref int d)
        {
            d = 100;
        }

        public void passTest(int d)
        {
            d = 1000;
        }
        public override void print() {
            Console.WriteLine("Child");
        }

        public void printTest()
        {
            Console.WriteLine("Child");
        }

    }
}
