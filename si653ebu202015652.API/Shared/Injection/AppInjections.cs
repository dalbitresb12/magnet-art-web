using si653ebu202015652.API.Painting.Injection;
using si653ebu202015652.API.Shared.Domain.Repositories;
using si653ebu202015652.API.Shared.Persistence.Repositories;
using si653ebu202015652.API.Training.Injection;

namespace si653ebu202015652.API.Shared.Injection;

public static class AppInjections {
  public static void Register(IServiceCollection services) {
    PaintingInjections.Register(services);
    TrainingInjections.Register(services);

    services.AddScoped<IUnitOfWork, UnitOfWork>();
  }
}
