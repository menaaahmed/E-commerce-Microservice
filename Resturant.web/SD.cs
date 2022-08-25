namespace Resturant.web
{
    public static class SD
    {
        public static string productApiBase { get; set; } //prop tb3 url
        
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
