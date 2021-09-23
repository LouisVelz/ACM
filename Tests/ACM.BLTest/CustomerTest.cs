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


            string expected = "Snow, Jhon";

            //act
            string actual = _customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FullNameFirstNameEmpty()
        {
            _customer.FirstName = "Jhon";

            string actual = _customer.FullName;
            string expected = "Jhon";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FullNameLastNameEmpty()
        {
            _customer.LastName = "Snow";

            string actual = _customer.FullName;
            string expected = "Snow";

            Assert.AreEqual(actual, expected);
        }
    }
}
