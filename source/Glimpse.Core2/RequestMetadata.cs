namespace Glimpse.Core2
{
    public class RequestMetadata
    {
        public string Uri { get; set; }
        public string HttpMethod { get; set; }
        public string GlimpseClientName { get; set; } //TODO: Should this be here or should cookie access be baked in?
        public int ResponseStatusCode { get; set; }
        public string ResponseContentType { get; set; }
        public string IpAddress { get; set; }
    }
}