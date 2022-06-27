using System;

namespace MiniAspnet {
    public interface IApplicationBuilder {
        RequestDelegate Build();
        IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);
    }
}
