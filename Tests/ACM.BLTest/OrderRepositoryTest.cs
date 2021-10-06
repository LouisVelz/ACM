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
    public class OrderRepositoryTest
    {
        private OrderRepository _orderRepository;
        private Order _order;
        [SetUp]
        public void SetUp()
        {
            _orderRepository = new OrderRepository();
            _order = new Order(1)
            {
                Customer = new Customer(1),
                OrderDate = new DateTimeOffset(),
                OrderItems = new List<OrderItem>()
            };

        }

        [Test]
        public void RetrieveList()
        {
            List<Order> expected = new List<Order>();

            var actual = _orderRepository.Retrieve();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
        
        [Test]
        public void RetrieveItem()
        {
            var newOrder = _orderRepository.Retrieve(1);

            Assert.AreEqual(_order.GetType(), newOrder.GetType());

        }

        [Test]
        public void SaveItem()
        {
            var actual = _orderRepository.Save(_order);
            //Assert
            Assert.AreEqual(true, actual);

        }
    }
}
