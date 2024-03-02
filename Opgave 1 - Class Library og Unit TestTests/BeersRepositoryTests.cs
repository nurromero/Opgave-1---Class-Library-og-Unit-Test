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
    public class BeersRepositoryTests
    {

        // Testing the Get method in my repository
        [TestMethod()]
        public void TestGet()
        {
            //Arrange
            BeersRepository repository = new BeersRepository();

            // Act
            var result = repository.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.Count);
        }

        // Testing the Add method
        [TestMethod()]
        public void TestAdd()
        {
            // Arrange
            BeersRepository repository = new BeersRepository();
            Beer beer = new Beer(7, "Raki", 4);

            // Act
            var result = repository.Add(beer);

            //Assert
            Assert.IsNotNull(result);
        }

        // Testing the Delete method
        [TestMethod()]
            public void TestDelete()
        {
            // Arrange
            BeersRepository repository = new BeersRepository();

            // Act
            Beer beerDelete = repository.GetById(1);
            repository.Delete(beerDelete);
            var result = repository.GetById(1);

            // assert
            Assert.IsNull(result);


        }


    }

   
}