﻿using System;
using GeometricShapes;

/*
 * ProfReynolds
 */

namespace Demonstrator_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ProfReynolds Demonstrator_3");
            Console.WriteLine();

            var triangle = new Triangle();
            triangle.SideLength = 123.456;
            TellAboutTheShape(triangle);

            Console.WriteLine();

            var square = new Square()
            {
                SideLength = 321.654
            };
            TellAboutTheShape(square);

            Console.WriteLine();

            TellAboutTheShape(new Pentagon()
            {
                SideLength = 1.123
            });

            Console.WriteLine();
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }

        static void TellAboutTheShape(IGeometricShapes thisShape)
        {
            Console.WriteLine($"This object is a {thisShape.GetType()}");
            Console.WriteLine(thisShape.Description());
            Console.WriteLine($"Number of Sides = {thisShape.NumberOfSides}");
            Console.WriteLine($"Length of the Sides = {thisShape.SideLength}");
            Console.WriteLine($"Perimeter of the shape = {thisShape.Perimeter()}");
            Console.WriteLine($"Area of the shape = {thisShape.Area()}");
        }
    }
}
