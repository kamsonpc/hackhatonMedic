using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HealthBack.Authorization.Roles;
using HealthBack.Authorization.Users;
using HealthBack.MultiTenancy;

namespace HealthBack.EntityFrameworkCore
{
    public class HealthBackDbContext : AbpZeroDbContext<Tenant, Role, User, HealthBackDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HealthBackDbContext(DbContextOptions<HealthBackDbContext> options)
            : base(options)
        {
        }
    }
}
