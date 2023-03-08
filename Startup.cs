using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenHaiDang_2011064530.Startup))]
namespace NguyenHaiDang_2011064530
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
