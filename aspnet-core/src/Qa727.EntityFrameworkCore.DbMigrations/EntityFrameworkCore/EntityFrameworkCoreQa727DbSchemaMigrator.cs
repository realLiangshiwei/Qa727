using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Qa727.Data;
using Volo.Abp.DependencyInjection;

namespace Qa727.EntityFrameworkCore
{
    public class EntityFrameworkCoreQa727DbSchemaMigrator
        : IQa727DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreQa727DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Qa727MigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Qa727MigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}