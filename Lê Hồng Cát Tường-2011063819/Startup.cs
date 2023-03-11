using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lê_Hồng_Cát_Tường_2011063819.Startup))]
namespace Lê_Hồng_Cát_Tường_2011063819
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
