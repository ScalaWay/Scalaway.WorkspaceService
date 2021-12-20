using ScalaWay.Domain.Abstractions.Entities;
using ScalaWay.EntityFrameworkCore.Repositories;

namespace WorkspaceService.EntityFrameworkCore
{
    public class WritableRepository<TAggregateRoot> : EntityFrameworkWritableSpecRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        public WritableRepository(WorkspaceDbContext dbContext) : base(dbContext)
        {
        }
    }
}