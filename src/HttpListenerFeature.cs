using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;

namespace MiniAspnet {
    public class HttpListenerFeature : IHttpRequestFeature, IHttpResponseFeature {
        Uri? IHttpRequestFeature.Url => context.Request.Url;
        NameValueCollection IHttpRequestFeature.Headers => context.Request.Headers;
        Stream IHttpRequestFeature.Body => context.Request.InputStream;

        NameValueCollection IHttpResponseFeature.Headers => context.Response.Headers;
        Stream IHttpResponseFeature.Body => context.Response.OutputStream;

        int IHttpResponseFeature.StatusCode {
            get => context.Response.StatusCode;
            set => context.Response.StatusCode = value;
        }

        private readonly HttpListenerContext context;

        public HttpListenerFeature(HttpListenerContext context) => this.context = context;
    }
}
