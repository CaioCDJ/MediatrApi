
namespace CqrsApi.Domain.Commands.Responses;

public class CreateCustomerResponse{
  
  public Guid Id { get; set; }
  public string name { get; set; }
  public string email { get; set; }
  public DateTime date { get; set; }
}
