using CqrsApi.Domain.Commands.Responses;
using CqrsApi.Domain.Commands.Requests;
using MediatR;

namespace CqrsApi.Domain.Commands.Handlers;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse> 
{
  public async Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken ){

    return new CreateCustomerResponse{
      name = "someone",
      email = "alguem@gmail.com",
      date = DateTime.Now
    };
  }
}
