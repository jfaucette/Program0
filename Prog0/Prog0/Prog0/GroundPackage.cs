// Program 1A
// CIS 200-75
// Fall 2014
// Due: 10/13/2014
// By: Javoni Faucette

// File: GroundPackage.cs
// GroundPackage serves as the child class of the Parcel hierachy derived from the Package class.
// GroundPackage calculates the cost based on the package dimensions and weight and the zone distance.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class GroundPackage : Package
    {
        // Constants for ZoneDistance
        private const decimal SIZE_CONSTANT = 0.2m;
        private const decimal DISTANCE_CONSTANT = 0.5m;

        // PreCondition: GroundPackage instantiated.
        // PostCondition: Calculate the Zonedistance between the two address zip's and returns it positively.
        public int ZoneDistance()
        {
            int OriginFirstDigit = Convert.ToInt32(OriginAddress.Zip.ToString("D5")[0]);
            int DestinationFirstDigit = Convert.ToInt32(DestinationAddress.Zip.ToString("D5")[0]);

            return Math.Abs(OriginFirstDigit - DestinationFirstDigit);
        } // End ZoneDistance method.

        // Constructor
        // PreCondition: Two Addresses and four non negative doubles.
        // PostCondition: Creates a GroundPackage
        public GroundPackage(Address anOrigin, Address aDestination, double aLength, double aWidth, double aHeight, double aWeight)
            : base(anOrigin, aDestination, aLength, aWidth, aHeight, aWeight)
        {
        }// End constructor.

        // PreCondition: GroundPackage must be instantiated.
        // PostCondition: returns the cost as a decimal.
        public override decimal CalcCost()
        {
            return SIZE_CONSTANT*((decimal)Length+(decimal)Width+(decimal)Height) + DISTANCE_CONSTANT*(ZoneDistance()+1)*((decimal)Weight);
        }// End CalcCost override method.

        // PreCondition: None.
        // PostCondition: Returns info formatted as strings.
        public override string ToString()  //   PreCon: GroundPackage must be instantiated. PostCon: outputs a formatted string with information.
        {
            return string.Format("{0}{2}Zone Distance: {1}", base.ToString(), ZoneDistance().ToString(), Environment.NewLine);
        } // End ToString method.
    } // End GroundPackage class.
}
