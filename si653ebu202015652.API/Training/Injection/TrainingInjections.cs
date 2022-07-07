using si653ebu202015652.API.Training.Domain.Repositories;
using si653ebu202015652.API.Training.Domain.Services;
using si653ebu202015652.API.Training.Persistence.Repositories;
using si653ebu202015652.API.Training.Services;

namespace si653ebu202015652.API.Training.Injection;

public static class TrainingInjections {
  public static void Register(IServiceCollection services) {
    services.AddScoped<IProviderRepository, ProviderRepository>();
    services.AddScoped<IProviderService, ProviderService>();
  }
}
