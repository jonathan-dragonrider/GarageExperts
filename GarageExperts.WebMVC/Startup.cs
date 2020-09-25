using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GarageExperts.WebMVC.Startup))]
namespace GarageExperts.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
