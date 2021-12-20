namespace WorkspaceService.Domain.Models.Workspaces
{
    public class WorkspaceTeam
    {
        public Workspace Workspace { get; set; }
        public Guid TeamKey { get; set; }
    }
}