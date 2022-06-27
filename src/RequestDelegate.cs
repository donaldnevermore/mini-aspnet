using System.Threading.Tasks;

namespace MiniAspnet {
    public delegate Task RequestDelegate(HttpContext context);
}
