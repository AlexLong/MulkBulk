using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MulkBulk.Startup))]
namespace MulkBulk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
