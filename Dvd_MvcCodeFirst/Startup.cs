using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dvd_MvcCodeFirst.Startup))]
namespace Dvd_MvcCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
