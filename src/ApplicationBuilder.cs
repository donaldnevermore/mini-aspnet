namespace MiniAspnet;

public class ApplicationBuilder : IApplicationBuilder {
    private readonly IList<Func<RequestDelegate, RequestDelegate>> middlewares =
        new List<Func<RequestDelegate, RequestDelegate>>();

    public RequestDelegate Build() {
        RequestDelegate next = context => {
            context.Response.StatusCode = 404;
            return Task.CompletedTask;
        };

        foreach (Func<RequestDelegate, RequestDelegate> middleware in middlewares.Reverse()) {
            next = middleware.Invoke(next);
        }

        return next;
    }

    public IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware) {
        middlewares.Add(middleware);
        return this;
    }
}
