using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdnetityExercise.Startup))]
namespace IdnetityExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
