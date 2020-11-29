// Program 1A
// CIS 200-01
// Fall 2019
// Due: 9/23/2019
// By: M3838

// File: GroundPackage.cs
// Package sent on ground, calculates cost of shipping based on package dimensions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
    class GroundPackage : Package
    {
       public const decimal SIZE_COST_FACTOR = .25m;   // cost factor for size
       public const decimal WEIGHT_COST_FACTOR = .45m;  //cost factor for weight

        //Precondition: None
        //Postcondition: The ground package is made with the specified origin address, destination
        //address, length, width, height, and weight.
        public GroundPackage(Address originAddress, Address destAddress, double length,
           double width, double height, double weight) : base(originAddress, destAddress, length, width, height, weight)
        {

        }

        private int ZoneDistance
        {
            //Precondition: None
            //Postcondition: Returns the zone distance.
            get
            {
                const int FIRST_DIGIT_FACTOR = 10000; // Denominator to extract 1st digit
                int zoneDist; //To hold zone distance.
                zoneDist = Math.Abs((OriginAddress.Zip / FIRST_DIGIT_FACTOR) - (DestinationAddress.Zip / FIRST_DIGIT_FACTOR));
                return zoneDist;
            }
        }

        //Precondition: None
        //Postcondition: The cost of the ground package is returned.
        public override decimal CalcCost()
        {
           
            return SIZE_COST_FACTOR * ((decimal)Length + (decimal)Width + (decimal)Height) + WEIGHT_COST_FACTOR * (ZoneDistance + 1) * ((decimal)Weight);
        }

        //Precondition: None
        //Postcondition: String representation of the ground package is returned.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Ground Package{NL}{base.ToString()}";
        }
    }
}
