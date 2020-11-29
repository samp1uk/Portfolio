// Program 1A
// CIS 200-01
// Fall 2019
// Due: 9/23/2019
// By: M3838

// File: AirPackage.cs
// Send package via air, tests how heavy the package is.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
    abstract class AirPackage : Package
    {
        //Precondition: None
        //Postcondition: Air package is created with specified values for origin address, destination address, length,
        //width, height, and weight
        public AirPackage(Address originAddress, Address destAddress, double length,
            double width, double height, double weight) : base(originAddress, destAddress,
                length, width, height, weight)
        {

        }

        //Precondition: None
        //Postcondition: Value for IsHeavy is returned.
        public bool IsHeavy()
        {
            if (Weight >= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Precondition: None
        //Postcondition: Value for IsLarge is returned.
        public bool IsLarge()
        {
            if ((Length + Width + Height) >= 75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Precondition: None
        //Postcondition: A string representation of the class is returned.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Air Package{NL}{base.ToString()}";
        }
    }
}
