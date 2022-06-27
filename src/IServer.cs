using System.Threading.Tasks;

namespace MiniAspnet {
    public interface IServer {
        Task StartAsync(RequestDelegate handler);
    }
}
