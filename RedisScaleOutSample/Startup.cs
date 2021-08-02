using Microsoft.AspNet.SignalR;
using Owin;

namespace RedisScaleOutSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //GlobalHost.DependencyResolver.UseRedis("10.0.2.2", 16379, string.Empty, "myApp");
            GlobalHost.DependencyResolver.UseStackExchangeRedis("10.0.2.2", 16379, string.Empty, "myApp");
            app.MapSignalR();
        }
    }
}