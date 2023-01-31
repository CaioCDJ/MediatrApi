using CqrsApi.Domain.Commands.Responses;
using CqrsApi.Domain.Commands.Requests;

namespace CqrsApi.Domain.Commands.Handlers;

public class CreateCustomerHandler : ICreateCustomerHandler
{

  public CreateCustomerResponse Handle(CreateCustomerRequest request ){

    return new CreateCustomerResponse{
      Id = Guid.NewGuid(),
      name = "someone",
      email = "alguem@gmail.com",
      date = DateTime.Now
    };
  }
}
