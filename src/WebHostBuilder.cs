using Microsoft.Extensions.Hosting;

namespace MiniAspnet {
    public class WebHostBuilder {
        public IHostBuilder HostBuilder { get; }
        public IApplicationBuilder ApplicationBuilder { get; }

        public WebHostBuilder(IHostBuilder hostBuilder, IApplicationBuilder applicationBuilder) {
            HostBuilder = hostBuilder;
            ApplicationBuilder = applicationBuilder;
        }
    }
}
