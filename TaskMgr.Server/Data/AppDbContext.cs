
using Microsoft.EntityFrameworkCore;
using TaskMgr.Shared;

namespace TaskMgr.Server.Data
{
    public class AppDbContext : DbContext
    {
        DbSet<Job> Tasks { get; set; }
        DbSet<JobLocation> TaskLocations { get; set; }
        DbSet<Worker> Workers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        
            
        
    }
}
