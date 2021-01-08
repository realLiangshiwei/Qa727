using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Qa727.EntityFrameworkCore
{
    [DependsOn(
        typeof(Qa727EntityFrameworkCoreModule)
        )]
    public class Qa727EntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<Qa727MigrationsDbContext>();
        }
    }
}
