using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITEvergreen.education.com.Startup))]
namespace ITEvergreen.education.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
