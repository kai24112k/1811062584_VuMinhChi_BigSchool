using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1811062584_VuMinhChi_BigSchool.Startup))]
namespace _1811062584_VuMinhChi_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
