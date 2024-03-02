using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave_1___Class_Library_og_Unit_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1___Class_Library_og_Unit_Test.Tests
{
    [TestClass()]
    public class BeerTests
    {
        // Test of the Beer constructor
        [TestMethod()]
        public void BeerTest()
        {
            // Arrange 
            var beer = new Beer(1, "Tuborg", 5);

            // Act & Assert
            try
            {
                beer.Validate();

            }
            catch (Exception ex)
            {
                Assert.Fail($"Unexpected exception: {ex.Message}");
            }

        }


        // To string test

        [TestMethod()]
        public void ToStringTest()
        {

            var beer = new Beer(1, "Pilsner", 5);
            string expected = "Id: 1, Name: Pilsner, ABV: 5";

            // Act
            string actual = beer.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }



        // Testing the ValidateName method, that will FAIL
        [TestMethod()]
        public void ValidateNameTest_Invalid()
        {
            //Arrange
            var beer = new Beer(1, "N", 5);
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => beer.ValidateName());
        }


        // Test for validating the ABV
        [TestMethod()]
        public void ValidateABVTest_Invalid()
        {
            // Arrange
            var beer = new Beer(1, "Elefant", 70);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.ValidateABV());

        }

        // Testing the Validate() method, where it should fail
        [TestMethod()]
        public void ValidateTest_Invalid()
        {
            // Arrange
            var beer = new Beer(1, "BLANC", 99); 

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Validate());
        }

    }
}
