using MediatR;
using CqrsApi.Domain.Commands.Responses;

namespace CqrsApi.Domain.Commands.Requests;

public class CreateCustomerRequest : IRequest<CreateCustomerResponse>{
  
  public string name { get; set; }
  public string email { get; set; }

}
