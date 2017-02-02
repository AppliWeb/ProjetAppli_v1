using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetAppli_v1.Startup))]
namespace ProjetAppli_v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
