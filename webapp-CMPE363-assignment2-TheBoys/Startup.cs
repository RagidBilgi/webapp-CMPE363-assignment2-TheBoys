using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webapp_CMPE363_assignment2_TheBoys.Startup))]
namespace webapp_CMPE363_assignment2_TheBoys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
