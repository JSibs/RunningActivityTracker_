using Microsoft.EntityFrameworkCore;
using RunningActivityTracker.Models;
using System.Collections.Generic;

namespace RunningActivityTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<RunningActivity> RunningActivities { get; set; }
    }
}
