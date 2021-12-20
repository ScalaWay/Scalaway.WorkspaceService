using Douanier.Abstractions.Permissions.Entities;
using Douanier.Attributes;
using Douanier.Permissions.Managers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WorkspaceService.Application.Contracts;
using WorkspaceService.Application.Contracts.Authorization;
using WorkspaceService.Application.Permissions.Commands;

namespace WorkspaceService.Api.Controllers
{
    [ApiController]
    [Authorize(
            AuthenticationSchemes = "Bearer",
            Roles = WorkspaceHelpers.Roles.Administrator)]
    [Route("workspace-service/v1/permissions")]
    public class PermissionController : ControllerBase
    {
        private readonly PermissionManager permissionManager;
        private readonly ILogger<PermissionController> logger;
        private readonly IMediator mediator;

        public PermissionController(
            PermissionManager permissionManager,
            IMediator mediator,
            ILogger<PermissionController> logger)
        {
            this.permissionManager = permissionManager ?? throw new ArgumentNullException(nameof(permissionManager));
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            this.logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Permission>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Permission>>> GetPermissions()
        {
            var result = await permissionManager.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{name}")]
        [ProducesResponseType(typeof(Permission), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Permission>> GetPermissionByName([FromQuery] string name)
        {
            var result = await permissionManager.GetByNameAsync(name);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<Permission>> CreatePermission([FromBody] CreatePermissionCommand command)
        {
            var result = await permissionManager.CreateAsync(new Permission(command.Name, command.DisplayName, command.Description));
            return Ok(result);
        }
    }
}