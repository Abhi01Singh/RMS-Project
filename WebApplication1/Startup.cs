using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApplication1.StartupOwin))]

namespace WebApplication1
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
