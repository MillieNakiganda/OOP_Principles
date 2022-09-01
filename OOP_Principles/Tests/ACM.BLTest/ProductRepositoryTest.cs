using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //--Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers",
                ProductName = "Sunflowers"

            };
            // -- Act
            var actual = productRepository.Retrieve(2);
            // --Assert
            Assert.AreEqual(actual.CurrentPrice, expected.CurrentPrice);
            Assert.AreEqual(actual.ProductName, expected.ProductName);
            Assert.AreEqual(actual.ProductDescription, expected.ProductDescription);
        }
    }
}
