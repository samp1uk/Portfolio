// Program 4
// CIS 199-01
// Due: 4/23/2019
// Grading ID: M2564

// This application calculates the distance between to zipcode and from zipcode how long it takes and how much it cost.  
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
            // Create 5 objects of GroundPackage class
            GroundPackage gp1 = new GroundPackage(12345, 54321, 10, 20, 10, 50);
            GroundPackage gp2 = new GroundPackage(1111, 54321, 50, 50, 40, 150);
            GroundPackage gp3 = new GroundPackage(50000, 10000, 70, 50, 40, 250);
            GroundPackage gp4 = new GroundPackage(12345, 9999, 70.5, 50.65, 30, 78);
            GroundPackage gp5 = new GroundPackage(54321, 99723, 100, 85, 55, 120);

            // Create an array and store these objects in packages array
            GroundPackage[] packages = { gp1, gp2, gp3, gp4, gp5 };

            // Call function to display packages
            DisplayPackages(packages);

            // Change gp1 and display it
            gp1.OriginZip = 55555;
            gp1.Length = 25.5;
            display(gp1);

            // Change gp2 and display it
            gp2.Length = -1;
            display(gp2);

        }

        static void DisplayPackages(GroundPackage[] packages)
        {
            // Iterate loop over packages array
            // Print package number
            // Print object at index i
            // Print shipping cost by calling fnction CalcCost
            for (int i = 0; i < packages.Length; i++)
            {
                Console.WriteLine("Package " + (i + 1) + "\n-----------------------------");
                Console.WriteLine(packages[i]);
                Console.WriteLine($"{"Shipping Cost",-20}: ${ packages[i].CalcCost()}");
                Console.WriteLine();
            }
        }

        static void display(GroundPackage package)
        {
            // Print package
            // Print shipping cost by calling function
            Console.WriteLine(package);
            Console.WriteLine($"{"Shipping Cost",-20}: ${ package.CalcCost()}");
            Console.WriteLine();
        }
    }
}

