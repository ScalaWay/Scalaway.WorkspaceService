using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WorkspaceService.Application.Contracts.Workspaces.Objects;
using WorkspaceService.Application.Workspaces.Commands.CreateWorkspace;
using WorkspaceService.Application.Workspaces.Commands.DeleteWorkspace;
using WorkspaceService.Application.Workspaces.Commands.UpdateWorkspace;
using WorkspaceService.Application.Workspaces.Queries.WorkspaceById;
using WorkspaceService.Application.Workspaces.Queries.WorkspacesList;

namespace WorkspaceService.Api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("workspace-service/v1/workspaces")]
    public class WorkspaceController : ControllerBase
    {
        private readonly ILogger<WorkspaceController> logger;
        private readonly IMediator mediator;

        public WorkspaceController(
            ILogger<WorkspaceController> logger,
            IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        /// <summary>
        /// Return full list of workspaces owned by current auth user.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<WorkspaceOutput>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<WorkspaceOutput>>> GetWorkspaces([FromQuery] WorkspacesListQuery query)
        {
            var workspaces = await mediator.Send(query);
            return Ok(workspaces);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(WorkspaceOutput), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<WorkspaceOutput>> GetWorkspaceById([FromQuery] WorkspaceByIdQuery query)
        {
            var workspace = await mediator.Send(query);
            return Ok(workspace);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<WorkspaceOutput>> CreateWorkspace([FromBody] CreateWokspaceCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateWorkspace([FromBody] UpdateWorkspaceCommand command)
        {
            await mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteWorkspace")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteWorkspace(Guid guid)
        {
            var command = new DeleteWorkspaceCommand() { Id = guid };
            await mediator.Send(command);
            return NoContent();
        }
    }
}