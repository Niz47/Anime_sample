using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WatchAndShare.Startup))]
namespace WatchAndShare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
