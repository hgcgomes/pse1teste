using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pse1.Startup))]
namespace pse1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
