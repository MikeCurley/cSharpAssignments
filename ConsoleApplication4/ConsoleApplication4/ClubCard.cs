using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//assignment 2 written by Michael Curley 14231371
//Enda Howley Programming 2

namespace ConsoleApplication4
{

    class ClubCard
    {
        private int idNumber;//private data fields
        private String fName;
        private String lName;
        private String address;
        private int loyaltyPoints;
        private static int pin = 1111;
        public ClubCard()
        {
            Console.WriteLine("Class Contructor");//initalise the datafields
            fName = "";
            lName = "";
            address = "";
            idNumber = 100;
            ++pin;
        }
        public int ID
        {
            set
            {//write property
                idNumber = value;
            }
            get
            {// return id NUMBER Read only
                return idNumber;
            }
        }
        public String firstName
        {
            set
            {//write property
                fName = value;
            }
            get
            {//read property
                return fName;
            }

        }
        public String LastName
        {
            set
            {//write property
                lName = value;
            }
            get
            {//read property
                return lName;
            }

        }
        public String Address
        {
            set
            {//write property
                address = value;
            }
            get
            {//read property
                return address;
            }

        }
        public int points
        {
            set
            {//write property
                loyaltyPoints = loyaltyPoints + value;
            }
            get
            {//read property
                return loyaltyPoints;
            }

        }

        public int pinNunber
        {
            get
            {//only read access no set access
                return pin;
            }
        }

        public void shopBonus(ref int d)
        {//ref does not have to be assigned in the method passing a reference to the method

            d = 130;
        }
        public void shopBonusOut(out int d)//passing a reference to the method
        {//the key difference between out and ref is that out has to be assigned in this method 
            //if you dont assign a value you get a compile error
            d = 150;
        }
        public void shopBonusValue(int d)
        {//This method accepts an integer argunment and d is set to 160 
            // but has no effect on the variable deposit in the main program
            d = 160;
            Console.WriteLine(" value of method variable  d in class  in pass by value   " + d);
        }
        public void display()
        {
            Console.WriteLine("Display Customers");
            Console.WriteLine("Customer Name:  " + fName + " " + lName + " Address: " + address + " Customer ID  " + idNumber + " TOTAL POINTS = " + loyaltyPoints);

        }
    }

}