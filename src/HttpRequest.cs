namespace MiniAspnet;

using System.Collections.Specialized;

public class HttpRequest {
    public Uri? Url => feature.Url;
    public NameValueCollection Headers => feature.Headers;
    public Stream Body => feature.Body;

    private readonly IHttpRequestFeature feature;

    public HttpRequest(IFeatureCollection features) => feature = features.Get<IHttpRequestFeature>();
}
