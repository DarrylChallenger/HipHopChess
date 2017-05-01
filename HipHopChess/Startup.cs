using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HipHopChess.Startup))]
namespace HipHopChess
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
