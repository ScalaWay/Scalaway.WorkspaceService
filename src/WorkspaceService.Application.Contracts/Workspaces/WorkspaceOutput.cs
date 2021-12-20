using WorkspaceService.Domain.Models.Workspaces;

namespace WorkspaceService.Application.Contracts.Workspaces.Objects
{
    public class WorkspaceOutput
    {
        public WorkspaceOutput(string workspaceName)
        {
            this.Name = workspaceName;
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? ShortDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public WorkspaceType Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid CreatorId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreateTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid LastModifierId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? LastModificationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}