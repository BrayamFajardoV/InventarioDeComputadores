using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MantenimientoDeEquipos.Startup))]
namespace MantenimientoDeEquipos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
