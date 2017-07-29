using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrivateBank.Startup))]
namespace PrivateBank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
