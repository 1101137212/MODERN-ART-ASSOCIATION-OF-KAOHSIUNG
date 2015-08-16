using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Startup))]
namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
