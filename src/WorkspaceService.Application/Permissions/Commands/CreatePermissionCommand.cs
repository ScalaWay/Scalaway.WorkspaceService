namespace WorkspaceService.Application.Permissions.Commands
{
    public class CreatePermissionCommand
    {
        public string Name { get; set; }

        public string? DisplayName { get; set; }

        public string? Description { get; set; }

        public Guid? GroupId { get; set; }
    }
}