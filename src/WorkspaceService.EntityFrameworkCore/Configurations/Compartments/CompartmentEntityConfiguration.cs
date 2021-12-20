using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkspaceService.Domain.Models.Compartments;

namespace WorkspaceService.EntityFrameworkCore.Configurations.Compartments
{
    public class CompartmentEntityConfiguration : IEntityTypeConfiguration<Compartment>
    {
        public void Configure(EntityTypeBuilder<Compartment> builder)
        {
            builder.ToTable("Compartments");
        }
    }
}