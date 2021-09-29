using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;
using NUnit.Framework;

namespace ACM.BLTest
{
    [TestFixture]
    public class OrderItemTests
    {
        private OrderItem _orderItem;
        private  Product _product;
        [SetUp]
        public void SetUp()
        {
            _product = new Product();
            _orderItem = new OrderItem();
            _orderItem.Product = new Product();
            _orderItem.Quantity = 5;
        }

        [Test]
        public void ProductTest()
        {
            Assert.AreEqual(_orderItem.Product.GetType(), _product.GetType());
        }

        [Test]
        public void isValid()
        {
            
            Assert.GreaterOrEqual(_orderItem.Quantity, 1);
            Assert.IsInstanceOf<Product>(_orderItem.Product);
        }

        [Test]
        public void ValidateFromOrderItem()
        {
            bool valid = _orderItem.Validate();
            Assert.IsTrue(_orderItem.Validate());
        }

        [Test]
        public void isPriceDouble()
        {
            _orderItem.PurchasePrice = 9.99;
            double num = new double();
            Assert.AreEqual(num.GetType(), _orderItem.PurchasePrice.GetType());
        }


    }
}
