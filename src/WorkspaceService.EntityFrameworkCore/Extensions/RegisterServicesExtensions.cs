using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScalaWay.Domain.Abstractions.Repositories;
using WorkspaceService.EntityFrameworkCore.Repositories;

namespace WorkspaceService.EntityFrameworkCore.Extensions
{
    public static class RegisterServicesExtensions
    {
        public static IServiceCollection RegisterWorkspaceDbContext(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<WorkspaceDbContext>(builder => builder.UseSqlite(configuration.GetConnectionString("Workspace"),
                sql => sql.MigrationsAssembly(configuration.GetValue<string>("MigrationAssembly"))));

            services.AddScoped(typeof(IWritableRepository<>), typeof(WritableRepository<>));
            services.AddScoped(typeof(IReadableSpecificationRepository<>), typeof(ReadableSpecRepository<>));
            services.AddScoped(typeof(IWritableSpecificationRepository<>), typeof(WritableRepository<>));

            return services;
        }

        public static IServiceCollection RegisterAuthorizationDbContext(
            this IServiceCollection services,
            IConfiguration configuration,
            Type permissionProvider)
        {
            services
                .AddDouanier(options =>
                {
                    options.Permission.PermissionProviders.Add(permissionProvider);
                })
                .AddDouanierContext<WorkspaceDouanierDbContext>(options =>
                {
                    options.ConfigureDbContext = builder => builder.UseSqlite(configuration.GetConnectionString("Authorization"),
                            sql => sql.MigrationsAssembly(configuration.GetValue<string>("MigrationAssembly")));
                });

            return services;
        }
    }
}