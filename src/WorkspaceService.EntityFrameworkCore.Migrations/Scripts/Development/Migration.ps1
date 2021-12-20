$ConfigurationMode = "Debug"

$WorkspaceMigrationName = "Workspace"
$WorkspaceDbContext = "WorkspaceDbContext"

$DouanierMigrationName = "Douanier"
$DouanierDbContext = "WorkspaceDouanierDbContext"

# Move to solution root directory
cd ../../

# Remove existing databases
rm ../WorkspaceService.Api/*.db

# Remove any existing migrations for WorkspaceDbContext
dotnet ef migrations remove --startup-project ../WorkspaceService.Api/ --context $WorkspaceDbContext --configuration Debug

# Remove any existing migrations for DouanierDbContext
dotnet ef migrations remove --startup-project ../WorkspaceService.Api/ --context $DouanierDbContext --configuration Debug

# Clean & rebuild solution
dotnet clean
dotnet build --no-incremental

# Create initial migration script for Workspace DbContext
dotnet ef migrations add $WorkspaceMigrationName --startup-project ../WorkspaceService.Api/ --context $WorkspaceDbContext --output-dir ./Workspaces/Development --configuration Production

# Create initial migration script for Douanier DbContext
dotnet ef migrations add $DouanierMigrationName --startup-project ../WorkspaceService.Api/ --context $DouanierDbContext --output-dir ./Authorization/Development --configuration Production

# Apply migrations
dotnet ef database update --startup-project ../WorkspaceService.Api/ --context $WorkspaceDbContext --configuration Debug
dotnet ef database update --startup-project ../WorkspaceService.Api/ --context $DouanierDbContext --configuration Debug