using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TruongAnhTuan_2011064166.Startup))]
namespace TruongAnhTuan_2011064166
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
