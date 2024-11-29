
using Microsoft.EntityFrameworkCore;
using TaskMgr.Shared;

namespace TaskMgr.Server.Data
{
    public class AppDbContext : DbContext
    {
        DbSet<Job> Jobs { get; set; }
        DbSet<JobLocation> JobLocations { get; set; }
        DbSet<Worker> Workers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        
            
        
    }
}
