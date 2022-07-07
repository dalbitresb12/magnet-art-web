using si653ebu202015652.API.Shared.Domain.Repositories;
using si653ebu202015652.API.Shared.Persistence.Contexts;

namespace si653ebu202015652.API.Shared.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork {
  private readonly AppDbContext context;

  public UnitOfWork(AppDbContext context) {
    this.context = context;
  }

  public async Task Complete() {
    await context.SaveChangesAsync();
  }
}
