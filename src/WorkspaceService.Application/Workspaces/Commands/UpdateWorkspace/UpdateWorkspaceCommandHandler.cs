using MediatR;

namespace WorkspaceService.Application.Workspaces.Commands.UpdateWorkspace
{
    public class UpdateWorkspaceCommandHandler : IRequestHandler<UpdateWorkspaceCommand>
    {
        public Task<Unit> Handle(UpdateWorkspaceCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}