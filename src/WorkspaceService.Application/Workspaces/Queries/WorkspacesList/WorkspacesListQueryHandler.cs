using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using ScalaWay.Domain.Abstractions.Repositories;
using ScalaWay.Utils.Extentions;
using WorkspaceService.Application.Contracts.Workspaces.Objects;
using WorkspaceService.Domain.Models.Workspaces;
using WorkspaceService.EntityFrameworkCore.Specifications.Workspaces;

namespace WorkspaceService.Application.Workspaces.Queries.WorkspacesList
{
    public class WorkspacesListQueryHandler : IRequestHandler<WorkspacesListQuery, List<WorkspaceOutput>>
    {
        private readonly HttpContext httpContext;
        private readonly IReadableSpecificationRepository<Workspace> workspaceRepository;
        private readonly IMapper mapper;

        public WorkspacesListQueryHandler(
            IHttpContextAccessor contextAccessor,
            IReadableSpecificationRepository<Workspace> workspaceRepository,
            IMapper mapper)
        {
            this.httpContext = contextAccessor.HttpContext;
            this.workspaceRepository = workspaceRepository ?? throw new ArgumentNullException(nameof(workspaceRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<WorkspaceOutput>> Handle(WorkspacesListQuery request, CancellationToken cancellationToken)
        {
            var currentUserId = this.httpContext.User.GetCurrentUserId();

            var workspaceSpec = new WorkspaceListSpec(currentUserId);
            var workspaceList = await workspaceRepository.FindAsync(workspaceSpec);
            return mapper.Map<List<WorkspaceOutput>>(workspaceList);
        }

        private async Task GetPrivateWorkspaces()
        {
        }

        private async Task GetTeamWorkspaces()
        {
        }
    }
}