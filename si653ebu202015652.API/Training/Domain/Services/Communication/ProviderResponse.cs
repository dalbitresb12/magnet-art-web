using si653ebu202015652.API.Shared.Domain.Service.Communication;
using si653ebu202015652.API.Training.Domain.Models;

namespace si653ebu202015652.API.Training.Domain.Services.Communication;

public class ProviderResponse : BaseResponse<Provider> {
  public ProviderResponse(string message) : base(message) {}
  public ProviderResponse(Provider resource) : base(resource) {}
}
