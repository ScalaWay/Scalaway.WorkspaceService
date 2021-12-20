using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkspaceService.Domain.Models.Workspaces;

namespace WorkspaceService.EntityFrameworkCore.Configurations.Workspaces
{
    public class CompartmentEntityConfiguration : IEntityTypeConfiguration<Workspace>
    {
        public void Configure(EntityTypeBuilder<Workspace> builder)
        {
            builder.ToTable("Workspaces");

            // Configure one to many relationship with Compartment
            builder.HasMany(pt => pt.Compartments)
                    .WithOne(t => t.Workspace);
        }
    }
}