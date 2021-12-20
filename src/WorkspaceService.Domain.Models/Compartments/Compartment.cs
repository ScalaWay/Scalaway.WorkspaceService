using ScalaWay.Domain.Abstractions.Entities;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using WorkspaceService.Domain.Models.Workspaces;

namespace WorkspaceService.Domain.Models.Compartments
{
    public class Compartment : IAggregateRoot<Guid>
    {

        private Workspace? workspace;

        public Compartment(string name, string? description = null)
        {
            Name = name;
            Description = description;
        }

        /// <summary>
        /// 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Workspace Workspace { 
            set => workspace = value;
            get => workspace ?? throw new InvalidOperationException($"Uninitialized property: {nameof(Workspace)}");
        }

        public Guid WorkspaceId { get; set; }
    }
}