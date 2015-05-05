using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kitter.Startup))]
namespace Kitter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
