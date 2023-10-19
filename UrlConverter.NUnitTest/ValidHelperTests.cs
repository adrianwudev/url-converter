using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlConverter.Helper;

namespace UrlConverter.NUnitTest
{
    public class ValidHelperTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase("https://example.co/ysrAXmrmzPmkug2Z")]
        [TestCase("http://example.co/ysrAXmrmzPmkug2Z")]
        public void IsUrlValid_TrueTest(string url)
        {
            var validHelper = new ValidHelper();
            bool isValid = validHelper.IsUrlValid(url);

            Assert.IsTrue(isValid);
        }

        [TestCase("htt://example.co/ysrAXmrmzPmkug2Z")]
        [TestCase("httpp://example.co/ysrAXmrmzPmkug2Z")]
        public void IsUrlValid_FalseTest(string url)
        {
            var validHelper = new ValidHelper();
            bool isValid = validHelper.IsUrlValid(url);

            Assert.IsFalse(isValid);
        }
    }
}
