using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DapperAsp.Startup))]
namespace DapperAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
