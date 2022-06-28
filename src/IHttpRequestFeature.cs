namespace MiniAspnet;

using System.Collections.Specialized;

public interface IHttpRequestFeature {
    Uri? Url { get; }
    NameValueCollection Headers { get; }
    Stream Body { get; }
}
