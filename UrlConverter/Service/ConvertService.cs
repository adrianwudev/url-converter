namespace UrlConverter.Service
{
    public class ConvertService
    {
        private readonly IConfiguration _config;
        private IConfigurationSection _configSection;
        private readonly string _baseUrl;
        private readonly int _maxLength;

        public ConvertService(IConfiguration config)
        {
            this._config = config;
            this._configSection = _config.GetSection("ShrinkUrlSettings");
            this._baseUrl = _configSection["BaseUrl"];
            this._maxLength = _configSection.GetValue<int>("MaxLength");
        }

        public string GetEncryptedUrl(string originalUrl)
        {
            string encryptedUrl = CrytographyService.EncryptUrl(originalUrl, _maxLength);

            return string.Concat(_baseUrl, encryptedUrl);
        }
    }
}
