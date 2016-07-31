using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidly_aspnet_learn.Startup))]
namespace vidly_aspnet_learn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
