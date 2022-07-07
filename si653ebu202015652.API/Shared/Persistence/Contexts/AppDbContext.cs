using Microsoft.EntityFrameworkCore;
using si653ebu202015652.API.Painting.Domain.Models;
using si653ebu202015652.API.Shared.Extensions;
using si653ebu202015652.API.Training.Domain.Models;

namespace si653ebu202015652.API.Shared.Persistence.Contexts;

public class AppDbContext : DbContext {
  private DbSet<Author>? authors;

  private DbSet<Provider>? providers;

  public AppDbContext(DbContextOptions options) : base(options) {}

  public DbSet<Author> Authors {
    get => GetContext(authors);
    set => authors = value;
  }

  public DbSet<Provider> Providers {
    get => GetContext(providers);
    set => providers = value;
  }

  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);

    var authorEntity = builder.Entity<Author>();
    authorEntity.ToTable("Authors");
    authorEntity.HasKey(p => p.Id);
    authorEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    authorEntity.Property(p => p.FirstName).IsRequired();
    authorEntity.Property(p => p.LastName).IsRequired();
    authorEntity.Property(p => p.Nickname).IsRequired();
    authorEntity.Property(p => p.PhotoUrl).HasDefaultValue(string.Empty);

    var providerEntity = builder.Entity<Provider>();
    providerEntity.ToTable("Providers");
    providerEntity.HasKey(p => p.Id);
    providerEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    providerEntity.Property(p => p.Name).IsRequired();
    providerEntity.Property(p => p.ApiUrl).HasDefaultValue(string.Empty);
    providerEntity.Property(p => p.KeyRequired).HasDefaultValue(false);
    providerEntity.Property(p => p.ApiKey).HasDefaultValue(string.Empty);

    builder.UseSnakeCase();
  }

  private static T GetContext<T>(T? ctx) {
    if (ctx == null) throw new NullReferenceException();
    return ctx;
  }
}
