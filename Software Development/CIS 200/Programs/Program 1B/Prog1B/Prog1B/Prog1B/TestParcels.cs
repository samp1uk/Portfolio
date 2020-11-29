// Program 1B
// CIS 200-01
// Fall 2019
// Due: 10/02/2019
// By: M3838

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Bony Clide", "398 Briarwood Street", 
                "Severn", "MD", 21144); //Test Address 5
            Address a6 = new Address("Jason Broune", "97 Center Avenue",
                "Boca Raton", "FL", 33428); //Test Address 6
            Address a7 = new Address("Robin William", "8333 Lancaster Drive",
                "State College", "PA", 16801); //Test Address 7
            Address a8 = new Address("Katrina Kafia", "73 El Dorado Street",
                "High Point", "NC", 27265); //Test Address 8


            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a6, a4, 2.30M);
            Letter letter3 = new Letter(a8, a3, 4.10M);

            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a1, a7, 12, 15, 16, 80);
            GroundPackage gp3 = new GroundPackage(a2, a8, 10, 12, 80, 50);

            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a3, a1, 10, 40, 35,
                61, 8.50M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a4, a2, 10, 15, 20, 10, 7.00M);

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a3, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a5, a4, 32, 65, 12,
                100, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a6, a5, 7, 7, 7, 
                10, TwoDayAirPackage.Delivery.Early);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);

            WriteLine("Original List:");
            WriteLine("===============================================================================================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("=========================");
            }
            
            //LINQ to sort parcels by the destination zip code
            var byDestZip =
                from p in parcels
                orderby p.DestinationAddress.Zip descending
                select p;

            // display LINQ results
            WriteLine("Results are order by destination zip (descending)"); //First task output label
            WriteLine("==============================================================================================="); //Line
            foreach (var p in byDestZip)//Loop that goes through each list in byDestZip and display the output.
            {
                WriteLine(p);
                WriteLine("=========================");
            }

            //LINQ that sorts parcels based on cost and puts it into ascending order.
            var byCost =
                from p in parcels
                orderby p.CalcCost() ascending
                select p;

            //display LINQ results
            WriteLine("Results are order by cost (ascending)");
            WriteLine("===============================================================================================");
            foreach (var p in byCost)//Loop that goes through each list in byCost and display the output.
            {
                WriteLine(p);
                WriteLine("=========================");
            }

            //LINQ that sorts the parcels based on their type (letter, airpackage, etc.) ascending and then by cost descending.
            var byTypeAndCost =
                from p in parcels
                orderby p.GetType().ToString() ascending, p.CalcCost() descending
                select p;

            //Display LINQ results
            WriteLine("Results of order by Parcel type (ascending) and then cost (descending).");
            WriteLine("===============================================================================================");
            foreach (var p in byTypeAndCost)//Loop that goes through each list in byTypeAndCost and display the output.
            {
                WriteLine(p);
                WriteLine("=========================");
            }

            //LINQ that sorts parcels that are air packages and are heavy by their weight. (descending)
            var heavyAirPackages =
                from p in parcels
                where p is AirPackage
                let parcel = p as AirPackage
                where parcel != null && parcel.IsHeavy()
                orderby parcel.Weight descending
                select parcel;

            //Display LINQ results
            WriteLine("Results of order by parcels that are air packages and are heavy by their weight. (descending)");
            WriteLine("===============================================================================================");
            foreach (var p in heavyAirPackages)//Loop that goes through each list in heavyAirPackages and display the output.
            {
                WriteLine(p);
                WriteLine("=========================");
            }

            
       }
    }
}
