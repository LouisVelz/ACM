using Acme.Common;
using NUnit.Framework;

namespace Acme.CommonTest
{
    public class StringHandlerTest
    {


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void SeparatesValidString()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            var actual = StringHandler.InsertSpaces(source);

            Assert.AreEqual( expected, actual);
        }

        [Test]
        public void ExtraExpacesTest()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            var actual = StringHandler.InsertSpaces(source);

            Assert.AreEqual(expected, actual);
        }
    }
}