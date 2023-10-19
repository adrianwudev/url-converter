namespace UrlConverter.Helper
{
    public class ValidHelper
    {
        private readonly HashSet<string> formats = new HashSet<string> { "http://", "https://" };
        public bool IsUrlValid(string url)
        {
            return formats.Any(fmt => url.StartsWith(fmt));
        }
    }
}
