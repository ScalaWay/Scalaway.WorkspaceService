using ScalaWay.Domain.Abstractions.Entities;

namespace WorkspaceService.Domain.Models.Books
{
    public class Project : IAggregateRoot<Guid>
    {
        public Project(string name)
        {
            Name = name;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }
    }
}