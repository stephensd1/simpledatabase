using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleDatabase2.Startup))]
namespace SimpleDatabase2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
