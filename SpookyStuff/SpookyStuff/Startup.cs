using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpookyStuff.Startup))]
namespace SpookyStuff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
