using si653ebu202015652.API.Painting.Domain.Repositories;
using si653ebu202015652.API.Painting.Domain.Services;
using si653ebu202015652.API.Painting.Persistence.Repositories;
using si653ebu202015652.API.Painting.Services;

namespace si653ebu202015652.API.Painting.Injection;

public static class PaintingInjections {
  public static void Register(IServiceCollection services) {
    services.AddScoped<IAuthorRepository, AuthorRepository>();
    services.AddScoped<IAuthorService, AuthorService>();
  }
}
