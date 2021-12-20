using MediatR;
using Microsoft.AspNetCore.Http;
using ScalaWay.Domain.Abstractions.Repositories;
using WorkspaceService.Application.Contracts.Workspaces.Objects;
using WorkspaceService.Domain.Models.Workspaces;

namespace WorkspaceService.Application.Workspaces.Commands.CreateWorkspace
{
    public class CreateWorkspaceCommandHandler : IRequestHandler<CreateWokspaceCommand, WorkspaceOutput>
    {
        private readonly HttpContext httpContext;
        private readonly IWritableSpecificationRepository<Workspace> workspaceRepository;

        public CreateWorkspaceCommandHandler(
            IHttpContextAccessor contextAccessor,
            IWritableSpecificationRepository<Workspace> workspaceRepository)
        {
            this.httpContext = contextAccessor.HttpContext;
            this.workspaceRepository = workspaceRepository;
        }

        public Task<WorkspaceOutput> Handle(CreateWokspaceCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}