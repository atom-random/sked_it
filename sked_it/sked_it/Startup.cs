using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sked_it.Startup))]
namespace sked_it
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
