using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace DatabaseDemonstratorTests
{
    [TestClass]
    public class ConventionalAdoTests
    {
        [TestMethod]
        public void RunQueryTableTest()
        {
            // Arrange
            var sqlConnectionString = Properties.Resources.SqlConnectionString;
            var dataTableQueryString = @"SELECT [CustomerID] ,[CompanyName] ,[ContactName] FROM [Customers]";

            // Act
            var conventionalAdo = new DatabaseDemonstrator.ConventionalAdo();
            var runQueryTable = conventionalAdo.RunQueryTable(sqlConnectionString, dataTableQueryString);

            // Assert
            runQueryTable.ShouldNotBeNull();

            runQueryTable.Columns.Count.ShouldBe(3);
            runQueryTable.Columns[0].ColumnName.ShouldBe("CustomerID");
            runQueryTable.Columns[1].ColumnName.ShouldBe("CompanyName");
            runQueryTable.Columns[2].ColumnName.ShouldBe("ContactName");

            runQueryTable.Rows.Count.ShouldBeGreaterThan(0);

            runQueryTable.Rows[0].ItemArray.Length.ShouldBe(3);
        }
    }
}
