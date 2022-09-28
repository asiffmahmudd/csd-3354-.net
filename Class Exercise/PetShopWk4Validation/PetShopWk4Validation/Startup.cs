using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetShopWk4Validation.Startup))]
namespace PetShopWk4Validation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
