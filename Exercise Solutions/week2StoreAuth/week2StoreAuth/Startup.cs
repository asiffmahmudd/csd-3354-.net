using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week2StoreAuth.Startup))]
namespace week2StoreAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
