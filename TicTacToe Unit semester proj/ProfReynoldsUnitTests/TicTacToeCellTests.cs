using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Middle_Tier;
using Shouldly;
using TicTacToe_Interfaces;

namespace ProfReynoldsUnitTests
{
    [TestClass]
    public class TicTacToeCellTests
    {
        [TestMethod]
        public void Verify_TicTacToeCell_Instantiation()
        {
            // arrange
            var ticTacToeCell = new TicTacToeCell();

            // act and assert

            ticTacToeCell.ShouldNotBeNull();
            ticTacToeCell.ShouldBeOfType<TicTacToeCell>();

            ticTacToeCell.CellOwner.ShouldBe(CellOwners.Open);
            ticTacToeCell.RowID.ShouldBe(0);
            ticTacToeCell.ColID.ShouldBe(0);
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(0, 1)]
        [DataRow(0, 4)]
        [DataRow(1, 0)]
        [DataRow(1, 1)]
        [DataRow(1, 4)]
        [DataRow(4, 0)]
        [DataRow(4, 1)]
        [DataRow(4, 4)]
        public void Verify_Assignment_Of_RowID_And_ColID(int assignedRowID, int assignedColID)
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // act and assert
            ticTacToeCell.RowID = assignedRowID;
            ticTacToeCell.RowID.ShouldBe(assignedRowID);
            ticTacToeCell.ColID = assignedColID;
            ticTacToeCell.ColID.ShouldBe(assignedColID);
        }

        [DataTestMethod]
        [DataRow(CellOwners.Error)]
        [DataRow(CellOwners.Open)]
        [DataRow(CellOwners.Human)]
        [DataRow(CellOwners.Computer)]
        public void Verify_Assignment_Of_CellOwner(CellOwners assignedCellOwner)
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // act and assert
            ticTacToeCell.CellOwner= assignedCellOwner;
            ticTacToeCell.CellOwner.ShouldBe(assignedCellOwner);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(5)]
        [DataRow(999)]
        public void Assignment_Of_RowID_Outside_Range_Should_Fault(int attemptedAssignment)
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action
            // na

            // assert
            Should.Throw<ArgumentOutOfRangeException>(() =>
            {
                ticTacToeCell.RowID = attemptedAssignment;
            });
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(5)]
        [DataRow(999)]
        public void Assignment_Of_ColID_Outside_Range_Should_Fault(int attemptedAssignment)
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action
            // na

            // assert
            Should.Throw<ArgumentOutOfRangeException>(() =>
            {
                ticTacToeCell.ColID = attemptedAssignment;
            });
        }

    }
}
