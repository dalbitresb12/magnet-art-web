using si653ebu202015652.API.Weather.Domain.Repositories;
using si653ebu202015652.API.Weather.Domain.Services;
using si653ebu202015652.API.Weather.Persistence.Repositories;
using si653ebu202015652.API.Weather.Services;

namespace si653ebu202015652.API.Weather.Injection;

public static class ForecastInjections {
  public static void Register(IServiceCollection services) {
    services.AddScoped<IForecastRepository, ForecastRepository>();
    services.AddScoped<IForecastService, ForecastService>();
  }
}
