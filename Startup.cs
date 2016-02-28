using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sHe_Ministries.Startup))]
namespace sHe_Ministries
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        
        {
            ConfigureAuth(app);
            
        }
    }
}
