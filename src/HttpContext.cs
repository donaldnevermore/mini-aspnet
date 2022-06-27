namespace MiniAspnet {
    public class HttpContext {
        public HttpRequest Request { get; }
        public HttpResponse Response { get; }

        public HttpContext(IFeatureCollection features) {
            Request = new HttpRequest(features);
            Response = new HttpResponse(features);
        }
    }
}
