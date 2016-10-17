using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeCookingwithData.Startup))]
namespace CodeCookingwithData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
