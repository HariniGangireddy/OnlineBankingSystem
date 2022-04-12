using Microsoft.Owin;
using OnlineBankingSystem.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineBankingSystem.Startup))]
namespace OnlineBankingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        public void createRolesandUsers()
        {
            var context = new ApplicationDbContext();

        }
    }
}
