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
    public class ProductTest
    {
        private Product _product;

        [SetUp]
        public void SetUp()
        {
            _product = new Product(1);
        }

        [TearDown]
        public void TearDown()
        {
            //Eliminate all created data
        }

        [Test]
        public void hasValidData()
        {
            _product.Name = "Vans";
            _product.CurrentPrice = 9.99;
            _product.Description = "Vans skating sneakers";

            Assert.AreEqual(true, _product.Validate());
        }

        [Test]
        public void hasInvalidData()
        {

            _product.Description = "Vans skating sneakers";
            Assert.AreEqual(false, _product.Validate());
        }

    }
}
