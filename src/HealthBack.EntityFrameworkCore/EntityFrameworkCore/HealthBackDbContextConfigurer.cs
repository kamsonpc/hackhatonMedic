using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HealthBack.EntityFrameworkCore
{
    public static class HealthBackDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HealthBackDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HealthBackDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
