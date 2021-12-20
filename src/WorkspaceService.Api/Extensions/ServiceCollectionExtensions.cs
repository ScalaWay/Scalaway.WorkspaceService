using WorkspaceService.Application.Extensions;
using WorkspaceService.Application.Permissions;
using WorkspaceService.EntityFrameworkCore.Extensions;

namespace WorkspaceService.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRequiredServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterWorkspaceDbContext(configuration);
            services.RegisterAuthorizationDbContext(configuration, typeof(WorkspacePermissionProvider));
            services.RegisterApplicationServices();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }

        public static IServiceCollection AddCustomAuthentication(this IServiceCollection services)
        {
            return services;
        }

    }
}
