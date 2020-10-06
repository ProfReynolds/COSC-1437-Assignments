﻿using System;
using System.Collections.Generic;
using System.Text;

/*
 * ProfReynolds
 */

namespace GeometricShapes
{
    public class Pentagon :IGeometricShapes
    {
        public int NumberOfSides => 5;

        public double SideLength { get; set; }

        public double Perimeter() => 5 * SideLength;

        public double Area()
        {
            return (Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4) * Math.Pow(SideLength, 2);
        }

        public int TotalMeasureOfAllAngles()
        {
            return 540;
        }

        public string Description()
        {
            return $"This Pentagon is a {NumberOfSides}-sided geometric shape. Each side is {SideLength} and the area is {Area()}";
        }
    }
}
