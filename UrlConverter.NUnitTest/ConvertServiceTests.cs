using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System.Collections.Generic;
using UrlConverter.Service;

namespace UrlConverter.NUnitTest
{
    public class ConvertServiceTests
    {
        private readonly string _baseUrl = "https://example.co/";
        private readonly string _maxLength = "16";

        [Test]
        public void GetEncryptedUrl_EqualTest()
        {
            string expectedEncryptedUrl = "https://example.co/ysrAXmrmzPmkug2Z";

            var mockSettings = new Dictionary<string, string>
            {
                {"ShrinkUrlSettings:BaseUrl", _baseUrl},
                {"ShrinkUrlSettings:MaxLength", _maxLength}
            };

            var mockConfig = new ConfigurationBuilder()
                .AddInMemoryCollection(mockSettings)
                .Build();
            ConvertService service = new ConvertService(mockConfig);

            string encyptedUrl = service.GetEncryptedUrl("https://www.quantbe.com/welcome/canada/logs/validate");

            Assert.AreEqual(expectedEncryptedUrl, encyptedUrl);
        }
    }
}