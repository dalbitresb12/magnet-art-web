using si653ebu202015652.API.Painting.Domain.Models;
using si653ebu202015652.API.Painting.Domain.Services.Communication;

namespace si653ebu202015652.API.Painting.Domain.Services;

public interface IAuthorService {
  Task<IEnumerable<Author>> ListAll();
  Task<AuthorResponse> Create(Author request);
}
