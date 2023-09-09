using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuongThuanQuang_Tuan2.Startup))]
namespace DuongThuanQuang_Tuan2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
