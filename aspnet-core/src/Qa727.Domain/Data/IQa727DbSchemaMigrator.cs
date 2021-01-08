using System.Threading.Tasks;

namespace Qa727.Data
{
    public interface IQa727DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
