using MediatR;
using WorkspaceService.Application.Contracts.Workspaces.Objects;

namespace WorkspaceService.Application.Workspaces.Queries.WorkspaceById
{
    public class GetWorkspaceByIdQueryHandler : IRequestHandler<WorkspaceByIdQuery, WorkspaceOutput>
    {
        public Task<WorkspaceOutput> Handle(WorkspaceByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}