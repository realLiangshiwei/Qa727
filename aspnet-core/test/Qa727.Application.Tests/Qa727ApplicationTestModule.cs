using Volo.Abp.Modularity;

namespace Qa727
{
    [DependsOn(
        typeof(Qa727ApplicationModule),
        typeof(Qa727DomainTestModule)
        )]
    public class Qa727ApplicationTestModule : AbpModule
    {

    }
}