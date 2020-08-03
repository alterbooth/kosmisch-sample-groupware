using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kosmisch.Sample.GroupwareApp.Startup))]
namespace Kosmisch.Sample.GroupwareApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
