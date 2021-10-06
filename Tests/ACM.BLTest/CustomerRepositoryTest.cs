using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;
using ACM.BL.Persistence;
using NUnit.Framework;

namespace ACM.BLTest
{
    [TestFixture]
    public class CustomerRepositoryTest
    {
        private CustomerRepository _customerRepository;
        private Customer _customer;
        [SetUp]
        public void SetUp()
        {
            _customerRepository = new CustomerRepository();
            _customer = new Customer(1) {EmailAddress = "JohnSnow@email.me", FirstName = "John", LastName = "Snow"};
        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void CustomerRetrieve()
        {

            //arrange


            //act
            var actual = _customerRepository.Retrieve(1);

            //assert

            Assert.AreEqual(_customer.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(_customer.FirstName, actual.FirstName);
            Assert.AreEqual(_customer.LastName, actual.LastName);
        }

        public void CustomerSave()
        {
            //Arrange
    
            //Act
            var actual = _customerRepository.Save(_customer);
            //Assert
            Assert.AreEqual(true,actual);
        }

    }
}
