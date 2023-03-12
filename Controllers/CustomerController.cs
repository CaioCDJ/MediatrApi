using Microsoft.AspNetCore.Mvc;
using CqrsApi.Domain.Commands.Requests;
using CqrsApi.Domain.Commands.Handlers;
using CqrsApi.Domain.Commands.Responses;
using MediatR;

namespace CqrsApi.Controllers;

[ApiController]
[Route("customer")]
public class CustomerController : ControllerBase
{
  [HttpPost]
  public async Task<IActionResult> Create(
    [FromServices]IMediator mediator,
    [FromBody]CreateCustomerRequest command)
  { 
    var e =  mediator.Send(command);

    return Ok(e);
  }
}
