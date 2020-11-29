// Program 4
// CIS 200-01
// Fall 2019
// Due: 11/25/2019
// By: M3838

//File: AscsTypeDescCost.cs
//This class sorts the list of parcels first by type (ascending) and then by cost (descending)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class AscsAndDesc :IComparer<Parcel>
    {
        //Precondition: None
        //Postcondition: When p1 < p2 return a negative number. When p1 == p2 return zero. When p1 > p2 return 
        //a positive number.
        public int Compare(Parcel p1, Parcel p2)
        {
            string p1Type; //Stores p1 type
            string p2Type; //Stores p2 type

            if (p1 == null && p2 == null)
                return 0;

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            p1Type = p1.GetType().ToString();
            p2Type = p2.GetType().ToString();

            //Compare the costs of the types
            if (p1Type == p2Type)
                return (p1.CalcCost()).CompareTo(p2.CalcCost());

            //Return the smaller of the two types
            return p1Type.CompareTo(p2Type);
        }
    }
}
