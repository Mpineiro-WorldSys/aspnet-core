using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Worldsys.LDI.EntityFrameworkCore
{
    public static class LDIDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LDIDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LDIDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}