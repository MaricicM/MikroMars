using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nas_Sajtic.Startup))]
namespace Nas_Sajtic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
