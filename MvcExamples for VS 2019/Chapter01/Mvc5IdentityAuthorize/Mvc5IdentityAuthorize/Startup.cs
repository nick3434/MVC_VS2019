using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5IdentityAuthorize.Startup))]
namespace Mvc5IdentityAuthorize
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
