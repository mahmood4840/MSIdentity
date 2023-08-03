using AspNetIdentity.Models;
using Microsoft.Owin;
using Microsoft.Owin.Builder;
using Owin;
using System.Web.Services.Description;

[assembly: OwinStartupAttribute(typeof(AspNetIdentity.Startup))]
namespace AspNetIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
