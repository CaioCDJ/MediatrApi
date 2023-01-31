using Microsoft.AspNetCore.Mvc;
using CqrsApi.Domain.Commands.Requests;
using CqrsApi.Domain.Commands.Handlers;
using CqrsApi.Domain.Commands.Responses;

namespace CqrsApi.Controllers;

[ApiController]
[Route("customer")]
public class CustomerController : ControllerBase
{
  [HttpPost]
  public CreateCustomerResponse Create(
    [FromServices]ICreateCustomerHandler handler,
    [FromBody]CreateCustomerRequest command)
  {
    return handler.Handle(command);
  }
}
