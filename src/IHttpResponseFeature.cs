using System.Collections.Specialized;
using System.IO;

namespace MiniAspnet {
    public interface IHttpResponseFeature {
        int StatusCode { get; set; }
        NameValueCollection Headers { get; }
        Stream Body { get; }
    }
}
