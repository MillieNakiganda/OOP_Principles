using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Millie";
            customer.LastName = "Nakiganda";
            string expected = "Nakiganda, Millie";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Millie";
            string expected = "Millie";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.LastName = "Nakiganda";
            customer.EmailAddress = "millienakiganda@gmail.com";
            bool expected = true;

            //--Act
            bool actual = customer.validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.EmailAddress = "millienakiganda@gmail.com";
            bool expected = false;

            //--Act
            bool actual = customer.validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
