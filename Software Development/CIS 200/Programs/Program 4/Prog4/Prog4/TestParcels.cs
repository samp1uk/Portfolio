// Program 4
// CIS 200-01
// Fall 2019
// Due: 11/25/2019
// By: M3838

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and generates specified reports using IComparer Class.


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
        // Postcondition: Parcels have been created and reports generated using LINQ
        static void Main(string[] args)
        {
            // Verbose Setting - true means complete output of parcel data
            //                   false means only relevant data output
            bool VERBOSE = false;

            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("John Doe", "111 Market St.",
                "Jeffersonville", "IN", 47130); // Test Address 5
            Address a6 = new Address("Jane Smith", "55 Hollywood Blvd.", "Apt. 9",
                "Los Angeles", "CA", 90212); // Test Address 6
            Address a7 = new Address("Captain Robert Crunch", "21 Cereal Rd.", "Room 987",
                "Bethesda", "MD", 20810); // Test Address 7
            Address a8 = new Address("Vlad Dracula", "6543 Vampire Way", "Apt. 1",
                "Bloodsucker City", "TN", 37210); // Test Address 8
            Address a9 = new Address("Bony Clide", "398 Briarwood Street",
                "Severn", "MD", 21144); //Test Address 9
            Address a10 = new Address("Jason Broune", "97 Center Avenue",
                "Boca Raton", "FL", 33428); //Test Address 10
            Address a11 = new Address("Robin William", "8333 Lancaster Drive",
                "State College", "PA", 16801); //Test Address 11
            Address a12 = new Address("Katrina Kafia", "73 El Dorado Street",
                "High Point", "NC", 27265); //Test Address 12

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a3, a4, 4.25M);                            // Letter test object
            Letter letter3 = new Letter(a11, a9, 5.75M);                           // Letter test object
            Letter letter4 = new Letter(a10, a12, 2.89M);                          // Letter test object
            GroundPackage gp1 = new GroundPackage(a5, a6, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a7, a8, 8.5, 9.5, 6.5, 2.5);     // Ground test object
            GroundPackage gp3 = new GroundPackage(a12, a4, 10, 12, 80, 50);        // Ground test object
            GroundPackage gp4 = new GroundPackage(a2, a9, 12, 15, 16, 80);         // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a3, a5, 9.5, 6.0, 5.5, // Next Day test object
                5.25, 5.25M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a2, a7, 10.5, 6.5, 9.5, // Next Day test object
                15.5, 5.00M);
            NextDayAirPackage ndap4 = new NextDayAirPackage(a12, a3, 10, 40, 35,    // Next Day test object
                61, 8.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a5, a7, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a8, a1, 15.0, 9.5, 6.5,   // Two Day test object
                75.5, TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a6, a4, 12.0, 12.0, 6.0,  // Two Day test object
                5.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap4 = new TwoDayAirPackage(a11, a10, 32, 65, 12,    // Two Day test object
                100, TwoDayAirPackage.Delivery.Early);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(letter4);

            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(gp4);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(ndap4);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);
            parcels.Add(tdap4);

            

            //The Original List and loop to display the list
            Title = "The Original List.";//change console title.
            WriteLine();
            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            Write($"Total Parcels: ");
            ForegroundColor = ConsoleColor.Cyan;
            Write($"{parcels.Count}");
            WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine();
            WriteLine("The Original List:");
            ForegroundColor = ConsoleColor.White;
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            WriteLine("Press Enter to Continue...");
            SetCursorPosition(0, 0); //set the output console view to the top of the output list. 
            Pause();
            


            //Ascending list by the cost and loop to display the ascending cost list. 
            parcels.Sort(); // sorts parcels by ascending cost.

            Title = "Items sorted in natural order (ascending by Cost).";//change console title.
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Items sorted in natural order (ascending by Cost):\n");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("====================");
            int i = 0; //number counter
            foreach (Parcel p in parcels)
            {
                i++;
                if (VERBOSE)
                    WriteLine(p);
                else
                    ForegroundColor = ConsoleColor.Green;
                Write($"({i}): ");
                ForegroundColor = ConsoleColor.Cyan;
                Write($"{p.CalcCost(),8:C}");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine();
                WriteLine("====================");
            }
            Pause();

            //Descending list their destination zip and loop to display the descending order by their destination zip 
            parcels.Sort(new DescByZip()); //Sort the zip codes by descending order

            Title = "Parcels sorted descending by their destination zip.";//change console title.
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Parcels sorted descending by their destination zip:\n");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("====================");
            int x = 0; //number counter
            foreach (Parcel p in parcels)
            {
                x++;
                if (VERBOSE)
                    WriteLine(p);
                else
                    ForegroundColor = ConsoleColor.Green;
                Write($"({x}): ");
                ForegroundColor = ConsoleColor.Cyan;
                Write($"{p.DestinationAddress.Zip,8:D5}");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine();
                WriteLine("====================");
            }
            Pause();

            //Ascending Type and Descending Cost list and loop for displaying that list. 
            parcels.Sort(new AscsAndDesc()); //Sort parcels first in ascending order by their type. Then it will sort in descending order by their cost.

            Title = "Parcels sorted ascending by parcels type and then sorted descending by their cost."; //change console title.
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Parcels sorted ascending by parcels type and then sorted descending by their cost:\n");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("===============================");
            int z = 0; //number counter
            foreach (Parcel p in parcels)
            {
                z++;
                if (VERBOSE)
                {
                    WriteLine(p);
                }
                else
                {
                    ForegroundColor = ConsoleColor.Gray;
                    Write($"({z}):");
                    ForegroundColor = ConsoleColor.Green;
                    Write($"{p.GetType().ToString(),-17}");
                    ForegroundColor = ConsoleColor.Cyan;
                    Write($"{p.CalcCost(),8:C}");
                    ForegroundColor = ConsoleColor.Gray;
                    WriteLine();
                    WriteLine("===============================");
                }
            }
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Clear(); // Clear screen
        }
    }
}
