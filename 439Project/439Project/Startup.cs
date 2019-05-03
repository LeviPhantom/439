using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_439Project.Startup))]
namespace _439Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
