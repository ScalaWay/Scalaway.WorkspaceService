using Douanier.EntityFrameworkCore;
using Douanier.EntityFrameworkCore.Options;
using Microsoft.EntityFrameworkCore;

namespace WorkspaceService.EntityFrameworkCore
{
    public class WorkspaceDouanierDbContext : DouanierDbContext
    {
        public WorkspaceDouanierDbContext(
            DbContextOptions<WorkspaceDouanierDbContext> options,
            DouanierDbContextOptions authorizationContextOptions) : base(options, authorizationContextOptions)
        {
        }
    }
}