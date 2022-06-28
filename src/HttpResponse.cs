namespace MiniAspnet;

using System.Collections.Specialized;

public class HttpResponse {
    public int StatusCode {
        get => feature.StatusCode;
        set => feature.StatusCode = value;
    }

    public NameValueCollection Headers => feature.Headers;
    public Stream Body => feature.Body;

    private readonly IHttpResponseFeature feature;

    public HttpResponse(IFeatureCollection features) => feature = features.Get<IHttpResponseFeature>();
}
