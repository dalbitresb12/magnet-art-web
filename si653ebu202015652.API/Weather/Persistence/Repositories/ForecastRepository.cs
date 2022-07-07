using Microsoft.EntityFrameworkCore;
using si653ebu202015652.API.Shared.Persistence.Contexts;
using si653ebu202015652.API.Shared.Persistence.Repositories;
using si653ebu202015652.API.Weather.Domain.Models;
using si653ebu202015652.API.Weather.Domain.Repositories;

namespace si653ebu202015652.API.Weather.Persistence.Repositories;

public class ForecastRepository : BaseRepository, IForecastRepository {
  public ForecastRepository(AppDbContext context) : base(context) {}

  public async Task<IEnumerable<Forecast>> ListAll() {
    return await context.Forecasts.ToListAsync();
  }

  public async Task Add(Forecast forecast) {
    await context.Forecasts.AddAsync(forecast);
  }

  public async Task<Forecast?> FindById(long id) {
    return await context.Forecasts.FindAsync(id);
  }

  public void Update(Forecast forecast) {
    context.Forecasts.Update(forecast);
  }

  public void Remove(Forecast forecast) {
    context.Forecasts.Remove(forecast);
  }
}
