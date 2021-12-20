namespace WorkspaceService.Application.Contracts.Authorization
{
    public static class ServicePermissions
    {
        public const string ServiceName = "WorkspaceService";

        public static class Workspaces
        {
            public const string All = $"{ServiceName}.Workspaces.All";
            public const string Read = $"{ServiceName}.Workspaces.Read";
            public const string Create = $"{ServiceName}.Workspaces.Create";
            public const string Update = $"{ServiceName}.Workspaces.Update";
            public const string Delete = $"{ServiceName}.Workspaces.Delete";
        }

        public static class Compartments
        {
            public const string All = $"{ServiceName}.Compartments.All";
        }

        public static class Projects
        {
            public const string All = $"{ServiceName}.Projects.All";
        }
    }
}