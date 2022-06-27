using System;
using System.Collections.Specialized;
using System.IO;

namespace MiniAspnet {
    public class HttpRequest {
        public Uri? Url => feature.Url;
        public NameValueCollection Headers => feature.Headers;
        public Stream Body => feature.Body;

        private readonly IHttpRequestFeature feature;

        public HttpRequest(IFeatureCollection features)
            => feature = features.Get<IHttpRequestFeature>();
    }
}
