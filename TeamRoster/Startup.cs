using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamRoster.Startup))]
namespace TeamRoster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
