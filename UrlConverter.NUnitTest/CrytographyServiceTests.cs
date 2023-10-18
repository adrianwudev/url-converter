using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlConverter.Service;

namespace UrlConverter.NUnitTest
{
    public class CrytographyServiceTests
    {
        [TestCase("http://example.co/ysrAXmrmzPmkug2Z", 5)]
        [TestCase("http://example.co/ysrAXmrmzPmkug2Z", 12)]
        public void EncryptUrl_LengthInRangeTest(string originalUrl, int maxLength)
        {   
            string encryptedUrl = CrytographyService.EncryptUrl(originalUrl, maxLength);
            bool isLengthInRange = encryptedUrl.Length <= maxLength;

            Assert.IsTrue(isLengthInRange);
        }
    }
}
