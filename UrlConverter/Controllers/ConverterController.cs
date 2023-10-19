using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using UrlConverter.Helper;
using UrlConverter.Request;
using UrlConverter.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlConverter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConverterController : ControllerBase
    {
        private readonly ConvertService _convertService;
        private readonly ValidHelper _validHelper;
        public ConverterController(IConfiguration conifg)
        {
            this._convertService = new ConvertService(conifg);
            this._validHelper = new ValidHelper();
        }

        // POST api/<ConverterController>
        [HttpPost]
        public string Post([FromBody] UrlData urlData)
        {
            if (urlData == null || string.IsNullOrEmpty(urlData.OriginalUrl))
                throw new ArgumentException("The original URL string is empty or null");
            if (!_validHelper.IsUrlValid(urlData.OriginalUrl))
                throw new FormatException("the original URL format is invalid");


            string encryptedUrl = _convertService.GetEncryptedUrl(urlData.OriginalUrl);
            return encryptedUrl;
        }
    }
}
