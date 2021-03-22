using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Contoso.EntityFrameworkCore
{
    public static class ContosoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ContosoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ContosoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
