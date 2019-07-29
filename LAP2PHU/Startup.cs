using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAP2PHU.Startup))]
namespace LAP2PHU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
