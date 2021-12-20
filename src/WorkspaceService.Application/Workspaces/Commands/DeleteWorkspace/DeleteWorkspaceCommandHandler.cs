using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using ScalaWay.Domain.Abstractions.Repositories;
using ScalaWay.Utils.Extentions;
using WorkspaceService.Application.Exceptions;
using WorkspaceService.Domain.Models.Workspaces;
using WorkspaceService.EntityFrameworkCore.Specifications.Workspaces;

namespace WorkspaceService.Application.Workspaces.Commands.DeleteWorkspace
{
    public class DeleteWorkspaceCommandHandler : IRequestHandler<DeleteWorkspaceCommand>
    {
        private readonly HttpContext httpContext;
        private readonly IWritableSpecificationRepository<Workspace> workspaceRepository;
        private readonly IMapper mapper;
        private readonly ILogger<DeleteWorkspaceCommandHandler> logger;

        public DeleteWorkspaceCommandHandler(
            IHttpContextAccessor contextAccessor,
            IWritableSpecificationRepository<Workspace> workspaceRepository,
            IMapper mapper,
            ILogger<DeleteWorkspaceCommandHandler> logger)
        {
            this.httpContext = contextAccessor.HttpContext;
            this.workspaceRepository = workspaceRepository ?? throw new ArgumentNullException(nameof(workspaceRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Unit> Handle(DeleteWorkspaceCommand request, CancellationToken cancellationToken)
        {
            var currentUserId = this.httpContext.User.GetCurrentUserId();

            var workspaceByIdSpec = new WorkspaceByIdSpec(currentUserId, request.Id);
            var workspaceToDelete = await workspaceRepository.FindBySpecAsync(workspaceByIdSpec);
            if (workspaceToDelete == null)
            {
                throw new NotFoundException(nameof(Workspace), request.Id);
            }

            await workspaceRepository.RemoveAsync(workspaceToDelete);

            logger.LogInformation($"Workspace {workspaceToDelete.Id} is successfully deleted.");

            return Unit.Value;
        }
    }
}