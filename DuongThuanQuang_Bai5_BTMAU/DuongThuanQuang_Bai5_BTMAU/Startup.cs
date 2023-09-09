using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuongThuanQuang_Bai5_BTMAU.Startup))]
namespace DuongThuanQuang_Bai5_BTMAU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
