using si653ebu202015652.API.Shared.Persistence.Repositories;
using si653ebu202015652.API.Weather.Domain.Repositories;
using si653ebu202015652.API.Weather.Injection;

namespace si653ebu202015652.API.Shared.Injection;

public static class AppInjections {
  public static void Register(IServiceCollection services) {
    ForecastInjections.Register(services);

    services.AddScoped<IUnitOfWork, UnitOfWork>();
  }
}
