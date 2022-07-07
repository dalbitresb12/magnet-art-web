using si653ebu202015652.API.Shared.Persistence.Contexts;

namespace si653ebu202015652.API.Shared.Persistence.Repositories;

public class BaseRepository {
  protected readonly AppDbContext context;

  public BaseRepository(AppDbContext context) {
    this.context = context;
  }
}
