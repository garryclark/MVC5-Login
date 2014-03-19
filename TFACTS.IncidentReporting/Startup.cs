using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TFACTS.IncidentReporting.Startup))]
namespace TFACTS.IncidentReporting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
