using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using NUnit.Framework;

namespace Acme.CommonTest
{
    [TestFixture]
    public class LoggingServiceTest
    {
        [Test]
        public void ServiceLogs()
        {
            var changedItems = new List<ILoggable>();
            //Arrange
            var customer = new Customer(1)
            {
                EmailAddress = "some@email.com",
                FirstName = "John",
                LastName = "Snow",
                AddressList = null
            };
            
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Shoes",
                ProductDescription = "Italian leader shoe",
                CurrentPrice = 100.00,
            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);

        }
    }
}