using Acme.Common;
using NUnit.Framework;

namespace Acme.CommonTest
{
    public class StringHandlerTest
    {
        private StringHandler _stringHandler;

        [SetUp]
        public void Setup()
        {
            _stringHandler = new StringHandler();
        }

        [Test]
        public void SeparatesValidString()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            var actual = _stringHandler.InsertSpaces(source);

            Assert.AreEqual( expected, actual);
        }

        [Test]
        public void ExtraExpacesTest()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            var actual = _stringHandler.InsertSpaces(source);

            Assert.AreEqual(expected, actual);
        }
    }
}