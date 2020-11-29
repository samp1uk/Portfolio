// Program 4
// CIS 200-01
// Fall 2019
// Due: 11/25/2019
// By: M3838

//This class sorts the list of parcels in descending order by destination zip.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
   
    class DescByZip : IComparer<Parcel>
    { 
        // Precondition:  None
        // Postcondition: When p1 < p2 returns negative number
        //                When p1 == p2 returns zero
        //                When p1 > p2 returns positive number
        public int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
                return 0;

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            //Return list in descending order
            return (p2.DestinationAddress.Zip).CompareTo(p1.DestinationAddress.Zip);
        }
    }
}
