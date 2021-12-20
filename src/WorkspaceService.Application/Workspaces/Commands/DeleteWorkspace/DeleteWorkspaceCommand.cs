using MediatR;

namespace WorkspaceService.Application.Workspaces.Commands.DeleteWorkspace
{
    public class DeleteWorkspaceCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}