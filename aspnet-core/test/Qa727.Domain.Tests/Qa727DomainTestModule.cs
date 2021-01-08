using Qa727.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Qa727
{
    [DependsOn(
        typeof(Qa727EntityFrameworkCoreTestModule)
        )]
    public class Qa727DomainTestModule : AbpModule
    {

    }
}