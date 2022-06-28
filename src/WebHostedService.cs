namespace MiniAspnet;

public class WebHostedService : IHostedService {
    private readonly IServer server;
    private readonly RequestDelegate handler;

    public WebHostedService(IServer server, RequestDelegate handler) {
        this.server = server;
        this.handler = handler;
    }

    public Task StartAsync(CancellationToken cancellationToken) => server.StartAsync(handler);
    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
