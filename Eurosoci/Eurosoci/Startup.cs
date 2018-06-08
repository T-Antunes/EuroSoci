using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eurosoci.Startup))]
namespace Eurosoci
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
