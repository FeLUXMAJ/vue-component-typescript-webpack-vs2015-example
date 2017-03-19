using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vue_component_typescript_webpack_vs2015_example.Startup))]
namespace vue_component_typescript_webpack_vs2015_example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
