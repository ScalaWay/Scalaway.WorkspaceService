using MediatR;
using WorkspaceService.Application.Contracts.Workspaces.Objects;

namespace WorkspaceService.Application.Workspaces.Commands.CreateWorkspace
{
    public class CreateWokspaceCommand : IRequest<WorkspaceOutput>
    {
        public string Name { get; set; }

        public CreateWokspaceCommand(string name)
        {
            this.Name = name;
        }
    }
}