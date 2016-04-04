// Program 1A
// CIS 200-75
// Fall 2014
// Due: 10/13/2014
// By: Javoni Faucette

// File: TwoDayAirPackage.cs
// TwoDayAirPackage serves as a concrete class derived from the AirPackage class.
// Two-day air packages may be delivered in the morning or the afternoon. If morning delivery is requested the package is an Early. 
// If afternoon delivery is requested, the package is a Saver and a discount will apply.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class TwoDayAirPackage : AirPackage
    {
        // Constants for calculating cost.
        private decimal _COST = 0.25m;
        private decimal SAVER_PERCENT = 0.10m;
        
        private char deliveryType; // Type char because of 'E' and 'S'
        //Get:
        // Precondition: None. 
        // PostCondition: returns a character, E or S.
        //Set:
        // PreCondition: must provide this set with the character E or S. 
        // PostCondition: verifies and sets the character to deliveryType
        public char DeliveryType
        {
            get { return deliveryType; }
            set
            {
                if (value == 'S' || value == 'E')
                    deliveryType = value;
                else
                    throw new ArgumentOutOfRangeException("DeliveryType", value, "Delivery type has to be either 'E' or 'S'");
            }
        } // End DeliveryType property.

        // PreCondition: Constructor Two Addresses, four non negative doubles, and the character delivery type E for Early or S for Saver. 
        // PostCondition: Creates a TwoDayAirPackage.
        public TwoDayAirPackage(Address originAddress, Address destinationAddress, double aLength, double aWidth, double aHeight, double aWeight, char aDeliveryType)
            : base(originAddress, destinationAddress, aLength, aWidth, aHeight, aWeight)
        {
            DeliveryType = aDeliveryType;
        } // End Constructor.

        // PreCondition: None, twodayairpackage must exist. 
        // PostCondition: outputs a decimal with the package's cost, based on the delivery type.
        public override decimal CalcCost()
        {
            decimal cost = _COST * ((decimal)Length + (decimal)Width + (decimal)Height) + _COST * (decimal)Weight; // I hope I did this part right!!
            if (DeliveryType == 'E')
                return cost;
            else
                return cost * (1 - SAVER_PERCENT);
        }

        // PreCondition: None.
        // PostCondition: Returns info formatted as strings.
        public override string ToString()
        {
            return string.Format("{2}{0}Delivery Type: {1}", Environment.NewLine, DeliveryType.ToString(), base.ToString());
        } // End ToString method.
    } // End TwoDayAirPackage class.
}
