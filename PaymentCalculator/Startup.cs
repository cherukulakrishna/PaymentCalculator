using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaymentCalculator.Startup))]
namespace PaymentCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
