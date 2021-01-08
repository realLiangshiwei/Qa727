using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Qa727.EntityFrameworkCore
{
    public static class Qa727DbContextModelCreatingExtensions
    {
        public static void ConfigureQa727(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(Qa727Consts.DbTablePrefix + "YourEntities", Qa727Consts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}