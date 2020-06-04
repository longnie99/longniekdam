using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YLongNieKDam_lab4.Startup))]
namespace YLongNieKDam_lab4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
