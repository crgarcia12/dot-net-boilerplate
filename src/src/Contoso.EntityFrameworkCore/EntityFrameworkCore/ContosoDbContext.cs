using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Contoso.Authorization.Roles;
using Contoso.Authorization.Users;
using Contoso.MultiTenancy;

namespace Contoso.EntityFrameworkCore
{
    public class ContosoDbContext : AbpZeroDbContext<Tenant, Role, User, ContosoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ContosoDbContext(DbContextOptions<ContosoDbContext> options)
            : base(options)
        {
        }
    }
}
