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
    abstract class Parcel
    {
        private Address _originAddress; //Backing field for origin address
        private Address _destAddress; //backing field for destination address

        //Constructor
        //Precondition: Parcel must have an origin and dest zip.
        //Postcondition: Constructs a parcel.
        public Parcel(Address originAddress, Address destAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destAddress;
        }


        protected Address OriginAddress
        {
            //Precondition: None
            //Postcondition: Returns origin address.
            get { return _originAddress;  }
            //Precondition: None
            //Postcondition: sets value to origin address.
            set { _originAddress = value; }
        }


        protected Address DestinationAddress
        {
            //Precondition: None
            //Postcondition: Returns destination address.
            get { return _destAddress; }
            //Preconditon: None
            //Postcondition: Sets value to destination address.
            set { _destAddress = value; }
        }


        public abstract decimal CalcCost();

        //Precondition: None
        //Postcondition: Returns a string representation of Parcel class.
        public override string ToString() =>
            "Origin Address: " + $"{OriginAddress}" + Environment.NewLine +
            "Destination Address: " + $"{DestinationAddress}" + Environment.NewLine;
    }
}
