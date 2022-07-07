using Microsoft.EntityFrameworkCore;
using si653ebu202015652.API.Shared.Extensions;
using si653ebu202015652.API.Weather.Domain.Models;

namespace si653ebu202015652.API.Shared.Persistence.Contexts;

public class AppDbContext : DbContext {
  private DbSet<Forecast>? forecasts;

  public AppDbContext(DbContextOptions options) : base(options) {}

  public DbSet<Forecast> Forecasts {
    get => GetContext(forecasts);
    set => forecasts = value;
  }

  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);

    var forecastEntity = builder.Entity<Forecast>();
    forecastEntity.ToTable("Forecasts");
    forecastEntity.HasKey(p => p.Id);
    forecastEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    forecastEntity.Property(p => p.Date).IsRequired();
    forecastEntity.Property(p => p.TemperatureC).IsRequired();

    builder.UseSnakeCase();
  }

  private static T GetContext<T>(T? ctx) {
    if (ctx == null) throw new NullReferenceException();
    return ctx;
  }
}
