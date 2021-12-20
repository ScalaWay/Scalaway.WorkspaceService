using ScalaWay.Domain.Abstractions.Entities;
using System.Collections.ObjectModel;
using WorkspaceService.Domain.Models.Compartments;

namespace WorkspaceService.Domain.Models.Workspaces
{
    public class Workspace : IAggregateRoot<Guid>
    {
        public Workspace(string name)
        {
            Name = name;
            Compartments = new Collection<Compartment>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }
        public WorkspaceType Type { get; set; }
        public Guid CreatorId { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.UtcNow;
        public Guid LastModifierId { get; set; }
        public DateTime? LastModificationTime { get; set; }

        #region Navigation properties

        public IEnumerable<Compartment> Compartments { get; set; }

        #endregion Navigation properties
    }
}