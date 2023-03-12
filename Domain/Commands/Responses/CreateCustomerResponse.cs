
namespace CqrsApi.Domain.Commands.Responses;

public class CreateCustomerResponse{
  
  Guid Id { get; set; } = Guid.NewGuid();
  public string name { get; set; }
  public string email { get; set; }
  public DateTime date { get; set; }
}
