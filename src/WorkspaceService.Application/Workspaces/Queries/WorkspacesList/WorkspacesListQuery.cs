using MediatR;
using WorkspaceService.Application.Contracts.Workspaces.Objects;

namespace WorkspaceService.Application.Workspaces.Queries.WorkspacesList
{
    public class WorkspacesListQuery : IRequest<List<WorkspaceOutput>>
    {
    }
}