using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Promovare_Evenimente.Startup))]
namespace Promovare_Evenimente
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
