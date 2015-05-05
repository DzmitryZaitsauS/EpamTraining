using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EpamTraining.Startup))]
namespace EpamTraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
