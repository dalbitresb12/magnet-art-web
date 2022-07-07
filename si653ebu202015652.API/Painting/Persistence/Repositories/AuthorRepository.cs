using Microsoft.EntityFrameworkCore;
using si653ebu202015652.API.Painting.Domain.Models;
using si653ebu202015652.API.Painting.Domain.Repositories;
using si653ebu202015652.API.Shared.Persistence.Contexts;
using si653ebu202015652.API.Shared.Persistence.Repositories;

namespace si653ebu202015652.API.Painting.Persistence.Repositories;

public class AuthorRepository : BaseRepository, IAuthorRepository {
  public AuthorRepository(AppDbContext context) : base(context) {}

  public async Task<IEnumerable<Author>> ListAll() {
    return await context.Authors.ToListAsync();
  }

  public async Task Add(Author entity) {
    await context.Authors.AddAsync(entity);
  }

  public async Task<Author?> FindByFirstNameAndLastName(string firstName, string lastName) {
    return await context.Authors.Where(p => p.FirstName == firstName)
      .Where(p => p.LastName == lastName)
      .SingleOrDefaultAsync();
  }

  public async Task<Author?> FindByNickname(string nickname) {
    return await context.Authors.Where(p => p.Nickname == nickname).SingleOrDefaultAsync();
  }
}
