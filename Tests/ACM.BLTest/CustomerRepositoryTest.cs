using System.Collections.Generic;
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

        [Test]
        public void RetrieveExistingWithAddress()
        {
            _customer.AddressList = new List<Address>()
            {

                new Address(1)
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shite",
                    County = "Middle Earth",
                    PostalCode = "11212",
                },
                new Address(2)
                {
                    AddressType = 2,
                    StreetLine1 = "Green Dragon",
                    City = "Bywater",
                    State = "Shire",
                    County = "Middle Earth",
                    PostalCode = "11212",
                }
            };

            var actual = _customerRepository.Retrieve(1);

            Assert.AreEqual(_customer.CustomerId, actual.CustomerId);
            Assert.AreEqual(_customer.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(_customer.FirstName, actual.FirstName);
            Assert.AreEqual(_customer.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(_customer.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(_customer.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(_customer.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(_customer.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(_customer.AddressList[i].County, actual.AddressList[i].County);
                Assert.AreEqual(_customer.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            } 

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
