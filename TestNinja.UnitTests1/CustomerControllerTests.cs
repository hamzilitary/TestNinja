using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests1
{
    [TestFixture]   
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            //Arrange
            var customerController = new CustomerController();
            //Act
            var result = customerController.GetCustomer(0);
            //Assert
            Assert.That(result, Is.TypeOf<NotFound>());

            //Assert.That(result, Is.InstanceOf<NotFound>());

        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            //Arrange
            var customerController = new CustomerController();
            //Act
            var result = customerController.GetCustomer(1);
            //Assert
            Assert.That(result, Is.TypeOf<Ok>());

        }
    }
}
