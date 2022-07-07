using si653ebu202015652.API.Painting.Domain.Models;

namespace si653ebu202015652.API.Painting.Domain.Repositories;

public interface IAuthorRepository {
  Task<IEnumerable<Author>> ListAll();
  Task Add(Author entity);
  Task<Author?> FindByFirstNameAndLastName(string firstName, string lastName);
  Task<Author?> FindByNickname(string nickname);
}
