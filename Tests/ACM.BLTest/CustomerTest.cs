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
            _customer = new Customer(2);
            Customer.InstanceCount = 1;
        }
        [TearDown]
        public void TearDown()
        {
            Customer.InstanceCount = 0;
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

        [Test]
        public void CompareStaticPropertyCount()
        {
            //static properties belongs to the class not to the instance of that class.
            Customer.InstanceCount += 1;
            Customer.InstanceCount += 1;

            int expected = 3;
            int actual = Customer.InstanceCount;

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void ValidateCustomerDataTest()
        {
            //arrange
            _customer.FirstName = "customer";


            //act
            var actual = _customer.Validate();

            //assert
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void ValidateValidCustomerDataTest()
        {
            //arrange
            _customer.FirstName = "customer";
            _customer.LastName = "valid data";

            //act
            var actual = _customer.Validate();

            //assert
            Assert.AreEqual(true, actual);
        }
    }
}
