// Program 1A
// CIS 200-75
// Fall 2014
// Due: 10/13/2014
// By: Javoni Faucette

// File: AirPackage.cs
// AirPackage serves as the abstract child class of the Parcel hierachy derived from the Package class.
// AirPackage adds methods to determine if the package is large or heavy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    abstract class AirPackage : Package
    {
       // Establishing constants weight and size constants.
       public const int WEIGHT_MAX = 75;
       public const int SIZE_MAX = 100;

       // PreCondition: None.
       // PostCondition: Checks to see if the weight is past the weight max then returns a True or False.
       public bool IsHeavy()
       {
           if (Weight >= WEIGHT_MAX) // If statement asking if the weight is over the weight max.
               return true;
           else
               return false;
       } // End IsHeavy method.

       // PreCondition: None. 
       // PostCondition: Checks to see if the dimensions are past the size max then returns a True or False.
       public bool IsLarge()
       {
           if (Length + Width + Height >= SIZE_MAX) // If statement asking if the dimensions is over the size max.
               return true;
           else
               return false;
       } // End IsLarge method.

       // Constructor
       // PreCondition: 2 Addresses and four non negative doubles.
       // PostCondition: Creates a GroundPackage
       public AirPackage(Address originAddress, Address destinationAddress, double aLength, double aWidth, double aHeight, double aWeight)
           : base(originAddress, destinationAddress, aLength, aWidth, aHeight, aWeight)
       {
       } // End constructor.

       // PreCondition: None.
       // PostCondition: Returns info formatted as strings.
       public override string ToString()
       {
           return string.Format("{3}{0}Heavy: {1}{0}Large: {2}", Environment.NewLine, IsHeavy().ToString(), IsLarge().ToString(), base.ToString());
       } // End ToString method.
    } // End AirPackage class.
}
