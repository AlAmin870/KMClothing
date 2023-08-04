using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KMClothing.Startup))]
namespace KMClothing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
