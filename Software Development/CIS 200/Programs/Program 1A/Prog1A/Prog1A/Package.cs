// Program 1A
// CIS 200-01
// Fall 2019
// Due: 9/23/2019
// By: M3838

// File: Package.cs
// A class to track length, width, and height of packages.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
    abstract class Package : Parcel
    {
        private double _length; //Backing field for package length.
        private double _width; //Backing field for width.
        private double _height; //Backing field for height.
        private double _weight; //Backing field for weight.
       
        //Precondition: Length, width, height, and weight must be >= 0.
        //Postcondition: The package is created with specified origin address, destination address, length,
        //width, height, and weight.
        public Package(Address originAddress, Address destAddress, double length, double width, double height, double weight)
            : base(originAddress, destAddress)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        public double Length
        {
            //Precondition: None
            //Postcondition: The package length has been returned.
            get { return _length; }
            //Precondition: Entered value must be greater than zero.
            //Postcondition: Length backing field is set to value.
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Length", value, "Length must be greater than zero");
                }
            }
        }

        public double Width
        {
            //Precondition: None
            //Postcondition: Width is returned.
            get { return _width; }
            //Precondition: Value entered for width must be greater than zero.
            //Postcondition: Width backing field is set to value.
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Width", value, "Width must be greater than zero");
                }
            }
        }

        public double Height
        {
            //Precondition: None
            //Postcondition: Height is returned.
            get { return _height; }
            //Precondition: Value entered for height but be greater than zero.
            //Postcondition: Backing field for height is set to value.
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Height", value, "Height must be greater than zero");
                }
            }
        }

        public double Weight
        {
            //Precondition: None
            //Postcondition: Weight is returned.
            get { return _weight; }
            //Precondition: Value must be greater than zero.
            //Postcondition: Backing field for weight is set to value.
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Weight", value, "Weight must be greater than zero");
                }
            }
        }

        //Precondition: None
        //Postcondition: A string with the package's data has been returned.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Package{NL}{base.ToString()}";

        }
    }
}
