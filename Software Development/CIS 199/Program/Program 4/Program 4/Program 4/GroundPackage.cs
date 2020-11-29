// Program 4
// CIS 199-01
// Due: 4/23/2019
// Grading ID: M2564

// This program uses a class to detetmine the package cost from the user input of Zipcode Send From, Zipcode Send To, Length, Width, Height, and Weight. 
// It takes all the user input and output not onlly thier input but how much it would cost them to send the pacakge. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class GroundPackage
    {
        // Private backing fields used to store value that no one else can see or use edit the values.
        private int _originZip;
        private int _destinationZip;
        private double _length;
        private double _width;
        private double _height;
        private double _weight;

        private int zoneDistDivide = 10000; //Used to divide the zipcode to find first digit of the user enterd zipcode.
        const double SIZE_COST_FACTOR = 0.25; //constant size cost for the package size no matter what size.
        const double WEIGHT_COST_FACTOR = 0.45; //constant weight cost for the package size no matter what thier weight.

        // OriginZip code property
        public int OriginZip
        {
            // Precondition: None
            // Postcondition: Retrives _originZip
            get { return _originZip; }

            // Precondition: 00000 < value > 99999
            // Postcondition: OriginZip is set to numberic value entered by user
            set
            {
                if(value > 00000 && value < 99999)
                {
                    _originZip = value;
                }
                else
                {
                    _originZip = 40202;
                }
            }

        }
        // DestinationZip code property
        public int DestinationZip
        {
            // Precondition: None
            // Postcondition: Retrives _destinationZip
            get { return _destinationZip; }

            // Precondition: 00000 < value > 99999
            // Postcondition: DestinationZip is set to numberic value entered by user
            set
            {
                if(value > 00000 && value < 99999)
                {
                    _destinationZip = value;
                }
                else
                {
                    _destinationZip = 90210;
                }
            }
        }
        //Length property
        public double Length
        {
            // Precondition: None
            // Postcondition: Retrives _length
            get { return _length; }

            // Precondition: value > 0
            // Postcondition: Length is set to numberic value entered by user
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    _length = 1.0;
                }
            }
        }
        //Width property
        public double Width
        {
            // Precondition: None
            // Postcondition: Retrives _width
            get { return _width; }
            // Precondition: value > 0
            // Postcondition: Width is set to numberic value entered by user
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    _width = 1.0;
                }
            }
        }
        //Height property
        public double Height
        {
            // Precondition: None
            // Postcondition: Retrives _height
            get { return _height; }

            // Precondition: value > 0
            // Postcondition: Height is set to numberic value entered by user
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1.0;
                }
            }
        }
        //Weight property
        public double Weight
        {
            // Precondition: None
            // Postcondition: Retrives _weight
            get { return _weight; }

            // Precondition: value > 0
            // Postcondition: Weight is set to numberic value entered by user
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    _weight = 1.0;
                }
            }
        }
        //ZoneDistance property
        public int ZoneDistance
        {
            // Precondition: None
            // Postcondition: Retrives the absolute value when subtracting the zipcode that the user input to be used for CalCost() calculation.
            get
            {
                int firstOrigin = OriginZip / zoneDistDivide;
                int secondDestination = DestinationZip / zoneDistDivide;
                return Math.Abs(firstOrigin - secondDestination);
            }
        }
        //CalcCost Method used to calculate the cost from all the property that user input and return the value as a double.
        public double CalcCost()
        {
            double cost = SIZE_COST_FACTOR * (Length + Width + Height) + WEIGHT_COST_FACTOR * (ZoneDistance + 1) * (Weight);
            return cost;
        }

        // Precondition: None
        // Postcondition: Creates a string to display ToString output of the user inputed value. when classed by the class
        public override string ToString()
        {
            return $"{"Origin ZipCode",-21}: {OriginZip}" + Environment.NewLine + $"{"Destination ZipCode",-21}: {DestinationZip}" + Environment.NewLine + $"{"Length",-21}: {Length}" + Environment.NewLine + $"{"Width",-21}: {Width}"
            + Environment.NewLine + $"{"Height",-21}: {Height}"  + Environment.NewLine + $"{"Weight",-21}: {Weight}";
        }
        // Constructor accepting six parameters
        public GroundPackage(int originZip, int destinationZip, double length, double width, double height, double weight)
        {
            OriginZip = originZip;
            DestinationZip = destinationZip;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }
    }
}
