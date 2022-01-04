using Microsoft.EntityFrameworkCore;
using SimCarTel.Dashboard.Domian.Models.Log;

namespace SimCarTel.Dashboard.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Level> Level { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Procedure> Procedure { get; set; }
        public DbSet<ServerLogs> ServerLogs { get; set; }
    }
}
