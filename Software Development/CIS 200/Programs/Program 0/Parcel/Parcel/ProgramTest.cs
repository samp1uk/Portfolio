// Program 0
// CIS 200-01
// Due: 9/09/2019
// Grading ID: M3838
// This program calcuate the shipping cost from one loaction to other. It also checks if the input is value or not so if it will be shipped.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Parcel
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
            //Create new address objects.
            Address address1 = new Address("James", "101 Wildwood Drive", "Louisville", "KY", 40220);
            Address address2 = new Address("Gordon", "1800 Preston HWY", "100 Outer Loop", "Louisville", "KY", 40245);
            Address address3 = new Address("Lucifer", "132 S 2nd Street", "Louisville", "KY", 40299);
            Address address4 = new Address("Morningstar", "175 Spring Street", "Louisville", "KY", 40248);

            //Create new letter objects
            Letter letter1 = new Letter(address1, address2, 10.00m);
            Letter letter2 = new Letter(address2, address4, 4.21m);
            Letter letter3 = new Letter(address3, address4, 8.92m);

            //Construct a lists of Parcels.
            List<Parcel> ParcelList = new List<Parcel>
            {
                letter1,
                letter2,
                letter3
            };

            //Loop to step through the list
            foreach (Parcel letter in ParcelList)
            {
                WriteLine(letter);
            }
            
        }
    }
}
