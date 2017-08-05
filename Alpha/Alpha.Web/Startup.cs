using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alpha.Web.Startup))]
namespace Alpha.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
