using si653ebu202015652.API.Painting.Domain.Models;
using si653ebu202015652.API.Painting.Domain.Repositories;
using si653ebu202015652.API.Painting.Domain.Services;
using si653ebu202015652.API.Painting.Domain.Services.Communication;
using si653ebu202015652.API.Shared.Domain.Repositories;

namespace si653ebu202015652.API.Painting.Services;

public class AuthorService : IAuthorService {
  private readonly IAuthorRepository repository;
  private readonly IUnitOfWork unitOfWork;

  public AuthorService(IAuthorRepository repository, IUnitOfWork unitOfWork) {
    this.repository = repository;
    this.unitOfWork = unitOfWork;
  }

  public Task<IEnumerable<Author>> ListAll() {
    return repository.ListAll();
  }

  public async Task<AuthorResponse> Create(Author request) {
    try {
      var authorWithFirstAndLastName = await repository.FindByFirstNameAndLastName(request.FirstName, request.LastName);

      if (authorWithFirstAndLastName is not null) {
        return new AuthorResponse("There's another author registered with the same first and last name.");
      }

      var authorWithNickname = await repository.FindByNickname(request.Nickname);

      if (authorWithNickname is not null) {
        return new AuthorResponse("There's another author registered with the same nickname.");
      }

      await repository.Add(request);
      await unitOfWork.Complete();
      return new AuthorResponse(request);
    } catch (Exception e) {
      return new AuthorResponse($"An error occurred while saving the author: {e.Message}");
    }
  }
}
