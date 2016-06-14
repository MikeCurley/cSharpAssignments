using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//assignment 2 written by Michael Curley 14231371
//Enda Howley Programming 2
namespace ConsoleApplication4
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = 1000;//making the screen wider so more readable
            //Assume money can be deposited to the club card
            int deposit = 0;
            //customer 1
            ClubCard c1 = new ClubCard();
            c1.firstName = "Mike";//settiing the values write access
            c1.LastName = "Curley";
            c1.Address = "Ballinasloe";
            c1.ID = 101;
            c1.points = 20;
            //customer 2
            ClubCard c2 = new ClubCard();
            c2.firstName = "John";
            c2.LastName = "Ford";
            c2.Address = "Loughrea";
            c2.ID = 102;
            c2.points = 30;
            //customer3
            ClubCard c3 = new ClubCard();
            c3.firstName = "Mary";
            c3.LastName = "Jones";
            c3.Address = "Tuam";
            c3.ID = 103;
            c3.points = 40;
            //display the customers using the display method in class

            Console.WriteLine("Customer Display");
            c1.display();
            c2.display();
            c3.display();
            Console.WriteLine("\n");
            //change address of 3 customers or objects


            c1.Address = "Cloghan";
            c2.Address = "Gort";
            c3.Address = "Athenry";
            Console.WriteLine("\n");
            //printing the updated addresses
            Console.WriteLine("Update Customer Address");
            c1.display();
            c2.display();
            c3.display();
            Console.WriteLine("\n");

            //updates points per customer
            c1.points = 50;
            c2.points = 60;
            c3.points = 20;
            //printing the updated points
            Console.WriteLine("Update Customer Points");
            c1.display();
            c2.display();
            c3.display();



            Console.WriteLine(c1.pinNunber); //just have read access no write access
            //c1.pinNunber = 1001; wont work as no write access

            Console.WriteLine("\n");
            Console.WriteLine("Customers Details using Getters");
            //data can be printed in main using setter/getter method using encapulatsion no direct access to datafield
            Console.WriteLine("Customer Name:  " + c1.firstName + " " + c1.LastName + " Address: " + c1.Address + " Customer ID  " + c1.ID);
            Console.WriteLine("Customer Name:  " + c2.firstName + " " + c2.LastName + " Address: " + c2.Address + " Customer ID  " + c2.ID);
            Console.WriteLine("Customer Name:  " + c3.firstName + " " + c3.LastName + " Address: " + c3.Address + " Customer ID  " + c3.ID);
            Console.WriteLine("\n");

            Console.WriteLine("VALUE OF DEPOSIT BEFORE REFERENCE TO DEPOSIT IS INVOKED " + deposit);

            c1.shopBonus(ref deposit);
            Console.WriteLine("PASSING A ARGUMENT REFERENCE USING REF");
            Console.WriteLine("Bonus for using loyalty club card " + deposit);
            Console.WriteLine("\n");
            c1.shopBonusOut(out deposit);
            Console.WriteLine("PASSING A ARGUMENT BY REFERENCE USING OUT ");
            Console.WriteLine("Bonus for using loyalty club card " + deposit);
            Console.WriteLine("\n");
            Console.WriteLine("PASSING A ARGUMENT BY VALUE  ");
            c1.shopBonusValue(deposit);//value at this point is 150
            Console.WriteLine("Bonus for using loyalty club card " + deposit);
            //as passing by value the variable deposit is not reference so therefor not updated so value remains at 150

        }
    }
}

