using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(authenticationTask.Startup))]
namespace authenticationTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
