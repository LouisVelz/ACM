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
            _product = new Product();
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

        [Test]
        public void retrievesProduct()
        {
            Product product = Product.Retrieve(new Guid());

            Assert.AreEqual(product.GetType(),_product.GetType());
        }

        [Test]
        public void retrievesListOfProducts()
        {
            List<Product> listOfProducts = Product.Retrieve();
            List<Product> otherList = new List<Product>();
            Assert.AreEqual(listOfProducts.GetType(), otherList.GetType());
        }

    }
}
