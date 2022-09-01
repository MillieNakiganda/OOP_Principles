using ACM.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACMCommonTest
{
    [TestClass]
    public class StringhndlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            //Act
            var actual = StringHandler.InsertSpaces(source);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void InsertSpacesTestWithExsitingSpaceValid()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            //Act
            var actual = StringHandler.InsertSpaces(source);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
