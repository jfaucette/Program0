// Program 0
// CIS 200-75
// Fall 2014
// Due: 9/2/2014
// By: Andrew L. Wright

// File: Program.cs
// Simple test program for initial Parcel classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45", 
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 1.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.25M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.75M); // Test Letter 3

            GroundPackage G1 = new GroundPackage(a1, a2, 10, 9, 4, 6);
            GroundPackage G2 = new GroundPackage(a2, a3, 14, 17, 8, 5);
            TwoDayAirPackage T1 = new TwoDayAirPackage(a1, a2, 6, 7, 8, 9, 'E');
            TwoDayAirPackage T2 = new TwoDayAirPackage(a3, a2, 5, 4, 8, 7, 'S');
            NextDayAirPackage N1 = new NextDayAirPackage(a1, a3, 3, 6, 9, 10, 4.6m);
            NextDayAirPackage N2 = new NextDayAirPackage(a3, a2, 15, 10, 12, 20, 5.0m);

            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);
            parcels.Add(G1);
            parcels.Add(G2);
            parcels.Add(T1);
            parcels.Add(T2);
            parcels.Add(N1);
            parcels.Add(N2);

            // Display data
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine();
            }
        }
    }
}
