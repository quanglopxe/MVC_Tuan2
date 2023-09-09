using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuongThuanQuang_Bai3_BTMAU.Startup))]
namespace DuongThuanQuang_Bai3_BTMAU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
