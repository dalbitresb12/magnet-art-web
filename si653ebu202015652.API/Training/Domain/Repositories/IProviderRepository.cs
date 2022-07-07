using si653ebu202015652.API.Training.Domain.Models;

namespace si653ebu202015652.API.Training.Domain.Repositories;

public interface IProviderRepository {
  Task<Provider?> FindById(int id);
  Task Add(Provider entity);
  Task<Provider?> FindByName(string name);
  Task<Provider?> FindByApiUrl(string? apiUrl);
}
