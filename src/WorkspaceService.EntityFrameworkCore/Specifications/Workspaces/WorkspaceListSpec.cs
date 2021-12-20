using ScalaWay.Specification;
using ScalaWay.Specification.Builder;
using WorkspaceService.Domain.Models.Workspaces;

namespace WorkspaceService.EntityFrameworkCore.Specifications.Workspaces
{
    public class WorkspaceListSpec : Specification<Workspace>
    {
        public WorkspaceListSpec(Guid ownerId)
        {
            Query.Where(workspace => workspace.CreatorId == ownerId);
        }
    }
}