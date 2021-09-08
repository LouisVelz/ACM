using ACM.BL;
using NUnit.Framework;

namespace ACM.BLTest
{
    [TestFixture]
    public class CustomerTest
    {
        private Customer _customer;
        [SetUp]
        public void SetUp()
        {
            _customer = new Customer();
        }

        [Test]
        public void Test1()
        {

            //arrange
            _customer.FirstName = "Jhon";
            _customer.LastName = "Snow";


            string expected = "yo yo yo";

            //act
            string actual = _customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
