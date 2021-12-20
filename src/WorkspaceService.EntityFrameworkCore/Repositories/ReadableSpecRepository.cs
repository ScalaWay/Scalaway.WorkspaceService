using ScalaWay.Domain.Abstractions.Entities;
using ScalaWay.EntityFrameworkCore.Repositories;

namespace WorkspaceService.EntityFrameworkCore.Repositories
{
    public class ReadableSpecRepository<TAggregateRoot> : EntityFrameworkSpecRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        public ReadableSpecRepository(WorkspaceDbContext dbContext) : base(dbContext)
        {
        }
    }
}