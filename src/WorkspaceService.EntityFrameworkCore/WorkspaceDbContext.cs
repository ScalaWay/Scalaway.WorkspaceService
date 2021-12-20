using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WorkspaceService.Domain.Models.Compartments;
using WorkspaceService.Domain.Models.Workspaces;

namespace WorkspaceService.EntityFrameworkCore
{
    public class WorkspaceDbContext : DbContext
    {
        public DbSet<Workspace> Workspaces => Set<Workspace>();
        public DbSet<Compartment> Compartments => Set<Compartment>();


        public WorkspaceDbContext(DbContextOptions<WorkspaceDbContext> options)
             : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Keep invoking base class of ASP.NET Identity DbContext
            // until full overriding and tests.
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}