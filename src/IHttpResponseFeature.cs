namespace MiniAspnet;

using System.Collections.Specialized;

public interface IHttpResponseFeature {
    int StatusCode { get; set; }
    NameValueCollection Headers { get; }
    Stream Body { get; }
}
