using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class GroundPackage
    {
        // Data members
        private int originZip;
        private int destinatonZip;
        private double length;
        private double width;
        private double height;
        private double weight;

        // Constructor to initialize data members
        // Use properties to set values
        public GroundPackage(int o, int d, double l, double w, double h, double we)
        {
            OriginZip = o;
            DestinatonZip = d;
            Length = l;
            Height = h;
            Width = w;
            Weight = we;

        }

        // Properties for all data members
        public int OriginZip
        {
            get { return originZip; }
            set
            {
                // If value is not valid, set it to, 40202
                if (value >= 10000 && value <= 99999)
                    originZip = value;
                else
                    originZip = 40202;
            }
        }

        public int DestinatonZip
        {
            get { return destinatonZip; }
            set
            {
                // If value is not valid, set it to, 90210
                if (value >= 10000 && value <= 99999)
                    destinatonZip = value;
                else
                    destinatonZip = 90210;
            }
        }

        public double Length
        {
            get { return length; }
            set
            {
                // If value is not valid, set it to 1
                if (value > 0)
                    length = value;
                else
                    length = 1.0;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                // If value is not valid, set it to 1
                if (value > 0)
                    width = value;
                else
                    width = 1.0;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                // If value is not valid, set it to 1
                if (value > 0)
                    height = value;
                else
                    height = 1.0;
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                // If value is not valid, set it to 1
                if (value > 0)
                    weight = value;
                else
                    weight = 1.0;
            }
        }

        public int ZoneDistance
        {
            get
            {
                // Find first digit of origin zip
                // Find first digit of destination zip
                // return absolute value of firstO - firstD
                int firstO = OriginZip / 10000;
                int firstD = DestinatonZip / 10000;
                return Math.Abs(firstO - firstD);
            }
        }

        public override string ToString()
        {

            // Use string interpolation to format strings
            // {"Origin ZipCode",-20} will set the string to left with width 20
            // same goes for other strings
            return $"{"Origin ZipCode",-20}: {OriginZip}" + Environment.NewLine +
            $"{"Destination ZipCode",-20}: {DestinatonZip}" + Environment.NewLine +
            $"{"Length",-20}: {Length}" + Environment.NewLine +
            $"{"Height",-20}: {Height}" + Environment.NewLine +
            $"{"Width",-20}: {Width}" + Environment.NewLine +
            $"{"Weight",-20}: {Weight}";
        }

        public double CalcCost()
        {
            // Calculate cost and return
            double cost = .25 * (Length + Width + Height) + .45 * (ZoneDistance + 1) * (Weight);
            return cost;

        }
    }
}
