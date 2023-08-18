using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OrderingSystem.Authorization.Roles;
using OrderingSystem.Authorization.Users;
using OrderingSystem.MultiTenancy;

namespace OrderingSystem.EntityFrameworkCore
{
    public class OrderingSystemDbContext : AbpZeroDbContext<Tenant, Role, User, OrderingSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OrderingSystemDbContext(DbContextOptions<OrderingSystemDbContext> options)
            : base(options)
        {
        }
    }
}
