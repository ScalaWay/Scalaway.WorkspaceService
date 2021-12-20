using ScalaWay.Specification;
using ScalaWay.Specification.Abstractions;
using ScalaWay.Specification.Builder;
using WorkspaceService.Domain.Models.Workspaces;

namespace WorkspaceService.EntityFrameworkCore.Specifications.Workspaces
{
    public class WorkspaceByIdSpec : Specification<Workspace>, ISingleResultSpecification
    {
        public WorkspaceByIdSpec(Guid owernerId, Guid workspaceId)
        {
            Query.Where(workspace => 
                workspace.CreatorId == owernerId && 
                workspace.Id == workspaceId);
        }
    }
}