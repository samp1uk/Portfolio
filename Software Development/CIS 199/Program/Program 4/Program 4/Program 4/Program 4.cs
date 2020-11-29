// Program 4
// CIS 199-01
// Due: 4/23/2019
// Grading ID: M2564

// This program uses a class to detetmine the package cost from the user input of Zipcode Send From, Zipcode Send To, Length, Width, Height, and Weight. 
// It takes all the user input and output not onlly thier input but how much it would cost them to send the pacakge. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //six object that have six hardcoded parameter that can be used for the GroundPackage class.
            GroundPackage GP1 = new GroundPackage(12345, 54321, 22, 18, 15, 20);
            GroundPackage GP2 = new GroundPackage(37087, 71292, 9, 6, 2, 10);
            GroundPackage GP3 = new GroundPackage(40228, 90001, 15, 12, 4, 30);
            GroundPackage GP4 = new GroundPackage(96704, 32004, 12, 0.5, 6.5, 5);
            GroundPackage GP5 = new GroundPackage(89131, 20017, 15, 15, 10, 75);
            GroundPackage GP6 = new GroundPackage(00000, 99999, 0, 0, 0, 0); //This object checks if the value condition are meet if not it set the backing field to default value.

            //Array that stores the six object into the array.
            GroundPackage[] packages = { GP1, GP2, GP3, GP4, GP5, GP6};

            //Calls a method and inputs the package arrays.
            DisplayPackages(packages);

            //This changes the data in the GroundPackage property value and call the method to display the changed property and output the result agian. 
            GP1.OriginZip = 22222;
            GP2.DestinationZip = 20101;
            GP3.Length = 10;
            GP4.Width = 9.5;
            GP5.Height = 11.5;
            GP6.Weight = 10;
            DisplayPackages(packages);

        }
        
        // Precondition: array entered in the DisplayPackages method that used for the foreach loop.
        // Postcondition: The display of the GroundPackage class ToString is displayed and the CalcCost() is also displayed from the user inputed values.
        public static void DisplayPackages(GroundPackage[] package)
        {
            int i = 0; //Used to count how many iteration it went through. 
            foreach (GroundPackage pack in package) //Loop to go though every array and display the ToString and the CalcCost.
            {
                i += 1; //add one to the variable i
                WriteLine("Package " + (i) + Environment.NewLine + "-------------------------------");
                WriteLine(pack); //display the ToString from the GroundPackage class. 
                WriteLine($"{"Shipping Cost",-21}: {pack.CalcCost():C}"); //Display the shipping cost in currency format.
                WriteLine("-------------------------------");
                WriteLine();
            }

            //for(int index = 0; index < package.Length; ++index) /Loop to go though every array and display the ToString and the CalcCost.
            //{
            //    WriteLine("Package " + (index + 1) + Environment.NewLine + "-------------------------------");
            //    WriteLine(package[index]); //display the ToString from the GroundPackage class. 
            //    WriteLine($"{"Shipping Cost",-21}: {package[index].CalcCost():C}"); //Display the shipping cost in currency format.
            //    WriteLine("-------------------------------");
            //    WriteLine();
            //}
        }
    }
}
