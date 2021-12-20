using MediatR;
using WorkspaceService.Application.Contracts.Workspaces.Objects;

namespace WorkspaceService.Application.Workspaces.Queries.WorkspaceById
{
    public class WorkspaceByIdQuery : IRequest<WorkspaceOutput>
    {
    }
}