using si653ebu202015652.API.Training.Domain.Models;
using si653ebu202015652.API.Training.Domain.Services.Communication;

namespace si653ebu202015652.API.Training.Domain.Services;

public interface IProviderService {
  Task<Provider?> GetById(int id);
  Task<ProviderResponse> Create(Provider request);
}
