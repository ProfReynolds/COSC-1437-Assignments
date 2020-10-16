﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using GeometricShapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

/*
 * ProfReynolds
 */

namespace GeometricShapes_Tests
{
    [TestClass]
    public class Triangle_Tests
    {
        [TestMethod]
        public void Verify_That_NumberOfSides_Is_3()
        {
            // Arrange
            var triangle = new Triangle();

            // Act

            // Assert
            triangle.NumberOfSides.ShouldBe(3);
        }

        [TestMethod]
        public void Verify_The_SideLength_May_Be_Set_And_Retrieved()
        {
            // Arrange
            var triangle = new Triangle();
            var expectedValue = 1.2d;

            // Act
            triangle.SideLength = expectedValue;

            // Assert
            triangle.SideLength.ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Perimeter_May_Be_Set_And_Retrieved()
        {
            // Arrange
            var triangle = new Triangle();
            var sideLength = 3.4d;
            var expectedValue = 10.2d;

            // Act
            triangle.SideLength = sideLength;

            // Assert
            triangle.Perimeter().ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Area_Is_Calculated_Accurately()
        {
            // Arrange
            var triangle = new Triangle();
            var sideLength = 5.6d; //resulting area = 13.579278331339997981255179317406
            var expectedAreaMinimumAcceptable = 13.579d;
            var expectedAreaMaximumAcceptable = 13.581d;

            // Act
            triangle.SideLength = sideLength;

            // Assert
            triangle.Area().ShouldBeInRange(expectedAreaMinimumAcceptable, expectedAreaMaximumAcceptable);
        }

        [TestMethod]
        public void Verify_TotalMeasureOfAllAngles_Is_Calculated_Accurately()
        {
            // Arrange
            var triangle = new Triangle();

            // Act
            var x = triangle.TotalMeasureOfAllAngles();

            // Assert
            triangle.TotalMeasureOfAllAngles().ShouldBe(180);
        }

        [TestMethod]
        public void Verify_The_Description_Returns_Value()
        {
            // Arrange
            var triangle = new Triangle();

            // Act

            // Assert
            triangle.Description().ShouldNotBeNullOrWhiteSpace();
        }
    }
}
