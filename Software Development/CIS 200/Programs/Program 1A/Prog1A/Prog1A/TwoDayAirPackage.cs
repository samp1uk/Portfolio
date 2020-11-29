// Program 1A
// CIS 200-01
// Fall 2019
// Due: 9/23/2019
// By: M3838

// File: TwoDayAirPackage.cs
// A class for packages being shipped two day air.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
    class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early, Saver }; //Defines 2 choice enumeration for delivery

        private Delivery _deliveryType; //Backing field to hold delivery type

        const decimal SIZE_COST_FACTOR = .20m;  //size factor for cost of Two Day Air Package
        const decimal WEIGHT_COST_FACTOR = .20m;  //weight factor for cost of Two Day Air Package 
        const decimal SAVER_COST_FACTOR = .15m; //saver factor for cost of Two Day Air Package

        //Precondition: None
        //Postcondition: Creates a two day air package with the specified paramter values.
        public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width,
            double height, double weight, Delivery deliveryType) : base(originAddress, destAddress, length, width, height, weight)
        {
            DeliveryType = deliveryType;
        }

        public Delivery DeliveryType
        {
            //Precondition: None
            //Postcondition: Returns delivery type
            get { return _deliveryType; }
            //Precondition: None
            //Postcondition: Sets delivery type to value
            set { _deliveryType = value; }
        }

        //Precondition: None
        //Postcondition: The calculated cost for the package is returned.
        public override decimal CalcCost()
        {
           
            decimal baseCost = SIZE_COST_FACTOR * ((decimal)Length + (decimal)Width + (decimal)Height) + WEIGHT_COST_FACTOR * ((decimal)Weight);
            if (DeliveryType == Delivery.Saver)
            {
                return baseCost - (baseCost * SAVER_COST_FACTOR);
            }
            else
            {
                return baseCost;
            }
        }

        //Precondition: None
        //Postcondition: Returns a string representation of the package.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"{NL}{base.ToString()}";
        }
    }
}

