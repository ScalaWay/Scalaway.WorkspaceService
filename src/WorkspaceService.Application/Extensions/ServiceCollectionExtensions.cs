using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WorkspaceService.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            // https://github.com/jbogard/MediatR/wiki
            services.AddMediatR(Assembly.GetExecutingAssembly());

            // https://docs.automapper.org/en/stable/Dependency-injection.html#asp-net-core
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}