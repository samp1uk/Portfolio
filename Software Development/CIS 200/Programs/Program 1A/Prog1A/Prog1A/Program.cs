// Program 1A
// CIS 200-01
// Fall 2019
// Due: 9/23/2019
// By: M3838

// File: Program.cs
// Simple test program for initial Parcel classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog1A
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3
            Package p1 = new NextDayAirPackage(a3, a4, 5, 5, 5, 75, 10); //Test if its heavy
            Package p2 = new NextDayAirPackage(a3, a4, 25, 25, 30, 30, 10); //Test if its large
            Package p3 = new NextDayAirPackage(a3, a4, 25, 25, 30, 80, 10); //Test if its large and heavy
            Package p4 = new NextDayAirPackage(a3, a4, 5, 5, 5, 5, 0); //Test regular
            Package p5 = new TwoDayAirPackage(a1, a2, 50, 20, 50, 100, TwoDayAirPackage.Delivery.Saver); //Test saver
            Package p6 = new TwoDayAirPackage(a2, a3, 10, 10, 10, 75, TwoDayAirPackage.Delivery.Early); //Test early

            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);
            parcels.Add(p1);
            parcels.Add(p2);
            parcels.Add(p3);
            parcels.Add(p4);
            parcels.Add(p5);
            parcels.Add(p6);

            // Display data
            WriteLine("Program 1A - List of Parcels\n");

            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("--------------------");
            }

           
        }
    }
}
