// Program 1A
// CIS 200-75
// Fall 2014
// Due: 10/13/2014
// By: Javoni Faucette

// File: NextDayAirPackage.cs
// NextDayAirPackage serves as a concrete class derived from the AirPackage class.
// NextDayAirPackage added methods to charge an extra Express Fee if the package is large/heavy and shipped the next day.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class NextDayAirPackage : AirPackage
    {
        // Constants for calculating cost.
        private const decimal DIMENTION_FACTOR = 0.40m;
        private const decimal WEIGHT_FACTOR = 0.30m;
        private const decimal _PENALTY = .25m;

        private decimal expressFee;

        // PreCondition: None, 
        // PostConditon: Returns expressFee.
        public decimal ExpressFee
        {
            get {return expressFee;}
        }

        // PreCondition: Two Addresses, four non negative doubles, and one non negative decimal.
        // PostCondition: Creates a NextDayAirPackage.
        public NextDayAirPackage(Address originAddress, Address destinationAddress, double aLength, double aWidth, double aHeight, double aWeight, decimal anExpressFee)
            : base(originAddress, destinationAddress, aLength, aWidth, aHeight, aWeight)
        {
            if (expressFee >= 0)  // If statement to validate the constructor because there is no set value in ExpressFee property.
                expressFee = ExpressFee;
            else
                throw new ArgumentOutOfRangeException("Express Fee", anExpressFee, "Express Fee can not be negative");
        }

        // PreCondition: None.
        // PostCondition: Returns the NextDayAirPackage cost as a decimal.
        public override decimal CalcCost() 
        {
            decimal cost = DIMENTION_FACTOR * ((decimal)Length + (decimal)Width + (decimal)Height) + WEIGHT_FACTOR * (decimal)Weight + ExpressFee;
            
            if (IsHeavy())
                cost += _PENALTY * (decimal)Weight; // If statement if its heavy to add the cost and penalty

            if (IsLarge())
                cost += _PENALTY * ((decimal)Length + (decimal)Width + (decimal)Height); //If statement if its large to add the cost and the dimenstion penalty.

            return cost;
        } // End CalcCost override method.

        // PreCondition: None.
        // PostCondition: Returns info formatted as strings.
        public override string ToString()
        {
            return string.Format("{1}{0}Express Fee: {2:C}", Environment.NewLine, base.ToString(), ExpressFee);
        } // End ToString method.
    }
}
