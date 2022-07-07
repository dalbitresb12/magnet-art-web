using Microsoft.EntityFrameworkCore;
using si653ebu202015652.API.Shared.Persistence.Contexts;
using si653ebu202015652.API.Shared.Persistence.Repositories;
using si653ebu202015652.API.Training.Domain.Models;
using si653ebu202015652.API.Training.Domain.Repositories;

namespace si653ebu202015652.API.Training.Persistence.Repositories;

public class ProviderRepository : BaseRepository, IProviderRepository {
  public ProviderRepository(AppDbContext context) : base(context) {}

  public async Task<Provider?> FindById(int id) {
    return await context.Providers.FindAsync(id);
  }

  public async Task Add(Provider entity) {
    await context.Providers.AddAsync(entity);
  }

  public async Task<Provider?> FindByName(string name) {
    return await context.Providers.Where(p => p.Name == name).SingleOrDefaultAsync();
  }

  public async Task<Provider?> FindByApiUrl(string? apiUrl) {
    return await context.Providers.Where(p => p.ApiUrl == apiUrl).SingleOrDefaultAsync();
  }
}
