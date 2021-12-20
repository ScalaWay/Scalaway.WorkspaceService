using Douanier.Abstractions.Permissions;
using Douanier.Abstractions.Permissions.Entities;
using Douanier.Permissions;
using WorkspaceService.Application.Contracts.Authorization;

namespace WorkspaceService.Application.Permissions
{
    public sealed class WorkspacePermissionProvider : PermissionProvider
    {
        public override void SetPermissions(IPermissionContext<PermissionGroup, Permission> permissionContext)
        {
            var workspacePermissionGroup = permissionContext.CreatePermissionGroup("Workspaces");

            permissionContext.CreatePermission(ServicePermissions.Workspaces.All, workspacePermissionGroup);
            permissionContext.CreatePermission(ServicePermissions.Workspaces.Read, workspacePermissionGroup);
            permissionContext.CreatePermission(ServicePermissions.Workspaces.Create, workspacePermissionGroup);
            permissionContext.CreatePermission(ServicePermissions.Workspaces.Update, workspacePermissionGroup);
            permissionContext.CreatePermission(ServicePermissions.Workspaces.Delete, workspacePermissionGroup);
        }
    }
}