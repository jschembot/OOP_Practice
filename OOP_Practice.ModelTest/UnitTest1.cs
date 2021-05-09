using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Practice.Model;

namespace OOP_Practice.ModelTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomerTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Frodo";
            c1.LastName = "Baggins";

            string expected = "Baggins, Frodo";

            // Act 
            string actual = c1.FullName;

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void InstanctCountTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Jon";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Edwards";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Schemmek";
            Customer.InstanceCount += 1;


            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateTest()
        {
            // arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "frodo123@gmail.com"
            };
            var expected = true;

            //act
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer
            {
                EmailAddress = "frodo123@gmail.com"
            };

            var expected = false;

            // act
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
