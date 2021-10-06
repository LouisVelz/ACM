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
    public class ProductRepositoryTest
    {
        private ProductRepository _productRepository;

        [SetUp]
        public void SetUp()
        {
            _productRepository = new ProductRepository();
        }

        [Test]
        public void retrievesProduct()
        {
            //arrange
            var expected = new Product(1);
            //act

            //assert
            var product = _productRepository.Retrieve(1);

            Assert.AreEqual(expected.GetType(),product.GetType());
        }

        [Test]
        public void retrievesListOfProducts()
        {
            List<Product> listOfProducts = _productRepository.Retrieve();
            List<Product> otherList = new List<Product>();
            Assert.AreEqual(listOfProducts.GetType(), otherList.GetType());
        }

    }
}
