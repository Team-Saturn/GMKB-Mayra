using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GMKB_Mayra.Startup))]
namespace GMKB_Mayra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
