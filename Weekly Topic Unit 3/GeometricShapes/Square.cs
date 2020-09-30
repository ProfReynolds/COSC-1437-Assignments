﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    public class Square
    {
        public int NumberOfSides
        {
            get { return 4; }
        }

        public double SideLength { get; set; }

        public double Perimeter()
        {
            return 4 * SideLength;
        }

        public double Area()
        {
            return SideLength *SideLength;
        }
    }
}
