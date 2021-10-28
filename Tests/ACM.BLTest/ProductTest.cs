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
        public void HasValidData()
        {
            _product.ProductName = "Vans";
            _product.CurrentPrice = 9.99;
            _product.ProductDescription = "Vans skating sneakers";

            Assert.AreEqual(true, _product.Validate());
        }

        [Test]
        public void HasInvalidData()
        {

            _product.ProductDescription = "Vans skating sneakers";
            Assert.AreEqual(false, _product.Validate());
        }

    }
}
