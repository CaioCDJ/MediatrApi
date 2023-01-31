using CqrsApi.Domain.Commands.Responses;
using CqrsApi.Domain.Commands.Requests;

namespace CqrsApi.Domain.Commands.Handlers;

public interface ICreateCustomerHandler{

  public CreateCustomerResponse Handle(CreateCustomerRequest request );
}
