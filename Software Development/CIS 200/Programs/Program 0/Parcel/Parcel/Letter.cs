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
    class Letter : Parcel
    {
        private decimal _fixedCost; //Backing field for fixed cost

        private const int minCost = 0; //The minimum cost required. 

        //constructor
        //Precondition: Must have an origin address, dest address, and fixed cost
        //Postcondition: Constructs a letter.
        public Letter(Address originAddress, Address destAddress, decimal fixedCost) : base(originAddress, destAddress)
        {
            FixedCost = fixedCost;
        }


        private decimal FixedCost
        {
            //Precondition: None
            //Postcondition: Returns fixed cost.
            get { return _fixedCost; }
            //Precondition: FixedCost must be greater than minCost and non negative. 
            //Postcondition: Sets value to fixed cost.
            set
            { 

                if (value > minCost )
                {
                    _fixedCost = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "The Cost must be greater than 0 and non negative.");
                }
            }
        }

        //Precondition: None
        //Postcondition: Returns fixed cost.
        public override decimal CalcCost()
        {
            return FixedCost;
        }

        //Precondition: None
        //Postcondition: Returns a string representation of letter.
        public override string ToString() =>
            "---------------------------------------------" + Environment.NewLine +
            "Origin Address: " + Environment.NewLine +
            $"{OriginAddress}" + Environment.NewLine + Environment.NewLine +
            "Destination Address: " + Environment.NewLine +
            $"{DestinationAddress}" + Environment.NewLine + Environment.NewLine +
            "Cost of shipping: " + $"{CalcCost():C}" + Environment.NewLine +
            "---------------------------------------------";
    }
}
