using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookSale.Startup))]
namespace BookSale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
