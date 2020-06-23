using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAnCoSo1.Startup))]

namespace DoAnCoSo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}