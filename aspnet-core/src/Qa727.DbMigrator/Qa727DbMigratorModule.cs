using Qa727.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Qa727.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Qa727EntityFrameworkCoreDbMigrationsModule),
        typeof(Qa727ApplicationContractsModule)
        )]
    public class Qa727DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
