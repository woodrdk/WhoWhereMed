using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhoWhere.Startup))]
namespace WhoWhere
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
