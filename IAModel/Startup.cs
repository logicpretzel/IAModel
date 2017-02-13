using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IAModel.Startup))]
namespace IAModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
