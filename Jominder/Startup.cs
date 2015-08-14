using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jominder.Startup))]
namespace Jominder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
