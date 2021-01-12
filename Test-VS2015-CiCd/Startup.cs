using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_VS2015_CiCd.Startup))]
namespace Test_VS2015_CiCd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
