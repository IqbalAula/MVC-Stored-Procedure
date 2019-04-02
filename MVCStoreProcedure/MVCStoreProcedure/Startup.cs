using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCStoreProcedure.Startup))]
namespace MVCStoreProcedure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
