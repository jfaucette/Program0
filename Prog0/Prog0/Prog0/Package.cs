// Program 1A
// CIS 200-75
// Fall 2014
// Due: 10/13/2014
// By: Javoni Faucette

// File: Package.cs
// Package serves as the abstract class of the Parcel hierachy. 
// Package tracks the dimensions in inches and weight in pounds of each package.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
   abstract class Package : Parcel 
    {
        // Establishing variables in Inches and Pounds.
        private double aLength;
        private double aWidth;
        private double aHeight;
        private double aWeight;
        
        //Properties
        //PreCondition: None. 
        //PostCondition: Will return a double for each property.
        public double Length
        {
            get { return aLength; } // End get.
            set
            {
                if (value >= 0) // If statement to make the property a non-negative double. Value has to be zero or above.
                {
                    aLength = value;
                } // End if statement.

                else
                {
                    throw new ArgumentOutOfRangeException("Length", value, string.Format("Length can't be negative")); //I hope I did these correctly I can't tell with the test data.
                } // End else statement.
            }// End set.
        } // End Length property.

        public double Width
        {
            get { return aWidth; } // End get.
            set
            {
                if (value >= 0) // If statement to make the property a non-negative double. Value has to be zero or above.
                {
                    aWidth = value;
                } // End if statement.

                else
                {
                    throw new ArgumentOutOfRangeException("Width", value, string.Format("Width can't be negative"));
                } // End else statement.
            } // End Set.
        } // End Width property.

        public double Height
        {
            get { return aHeight; } // End get.
            set
            {
                if (value >= 0) // If statement to make the property a non-negative double. Value has to be zero or above.
                {
                    aHeight = value;
                } // End if statement.

                else
                {
                    throw new ArgumentOutOfRangeException("Height", value, string.Format("Height can't be negative"));
                } // End else statement.
            } // End Set.
        } // End Height property.

        public double Weight
        {
            get { return aWeight; } // End get.
            set
            {
                if (value >= 0) // If statement to make the property a non-negative double. Value has to be zero or above.
                {
                    aWeight = value;
                } // End if statement.

                else
                {
                    throw new ArgumentOutOfRangeException("Weight", value, string.Format("Weight can't be negative"));
                } // End else statement.
            } // End Set.
        } // End Weight property.

        // PreCondition: Two Addreses and four non negative doubles.
        // PostCondition: Creates a Package (abstract, constructor will be used in child classes).
        public Package(Address originAddress, Address destinationAddress, double aLength, double aWidth, double aHeight, double aWeight)
            : base(originAddress, destinationAddress)
        {
            Length = aLength;
            Width = aWidth;
            Height = aHeight;
            Weight = aWeight;
        }

        // Method
        // PreConditon: None.
        // PostCondition: Returns info formatted string with currency formatting.
        public override string ToString()
        {
            return string.Format("{6}{4}Length: {0}{4}Width: {1}{4}Height: {2}{4}Weight: {3}{4}Cost: {5:C}", Length, Width, Height, Weight, Environment.NewLine, CalcCost(), base.ToString());
        } // End ToString method.
    } //End Package class.
}
