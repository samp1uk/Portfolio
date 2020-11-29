// Program 1A
// CIS 200-01
// Fall 2019
// Due: 9/23/2019
// By: M3838

// File: NextDayAirPackage.cs
// A class for packages being sent next day air.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
    class NextDayAirPackage : AirPackage
    {
        private double _expressFee; //Backing field for express fee.

        const decimal SIZE_COST_FACTOR = .30m;    //cost factor for base cost of Next Day Air Package
        const decimal WEIGHT_COST_FACTOR = .25m;   //weight factor for base cost of Next Day Air Package
        const decimal WEIGHT_CHARGE_FACTOR = .20m;  //wight factor for weight charge of Next Day Air Package
        const decimal SIZE_CHARGE_FACTOR = .20m;    //size factor for size charge of Next Day Air Package 


        //Precondition: None
        //Postcondition: Next day air package is constructed with the specified parameter values.
        public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width,
            double height, double weight, double expressFee) : base(originAddress, destAddress, length, width,
                height, weight)
        {
            ExpressFee = expressFee;
        }

        public double ExpressFee
        {
            //Precondition: None
            //Postcondition: Express fee is returned.
            get
            {
                return _expressFee;
            }
            //Precondition: Express fee must be greater than or equal to zero.
            //Postcondition: Express fee is set to value.
            private set
            {
                if (value >= 0)
                {
                    _expressFee = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("ExpressFee", value, "Express fee can not be a negative number.");
                }
            }

        }
        //Precondition: None
        //Postcondition: The cost of the next day air package is returned.
        public override decimal CalcCost()
        {
           
            decimal baseCost = SIZE_COST_FACTOR * ((decimal)Length + (decimal)Width + (decimal)Height) + WEIGHT_COST_FACTOR * ((decimal)Weight) + (decimal)ExpressFee;
            decimal weightCharge = WEIGHT_CHARGE_FACTOR * ((decimal)Weight);
            decimal sizeCharge = SIZE_CHARGE_FACTOR * ((decimal)Length + (decimal)Width + (decimal)Height);

            if(IsHeavy() && IsLarge())
            { return baseCost += weightCharge + sizeCharge; }
            else if (IsHeavy())
            {
                return baseCost += weightCharge;
            }
            else if (IsLarge())
            {
                return baseCost += sizeCharge;
            }
            else
            {
                return baseCost;
            }
        }

        //Precondition: None
        //Postcondition: A string representation of the class is returned.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"{NL}{base.ToString()}";
        }
    }
}
