using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Qa727.Data
{
    /* This is used if database provider does't define
     * IQa727DbSchemaMigrator implementation.
     */
    public class NullQa727DbSchemaMigrator : IQa727DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}