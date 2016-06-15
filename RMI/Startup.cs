using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RMI.Startup))]
namespace RMI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
