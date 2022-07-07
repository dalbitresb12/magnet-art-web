using si653ebu202015652.API.Painting.Domain.Models;
using si653ebu202015652.API.Shared.Domain.Service.Communication;

namespace si653ebu202015652.API.Painting.Domain.Services.Communication;

public class AuthorResponse : BaseResponse<Author> {
  public AuthorResponse(string message) : base(message) {}
  public AuthorResponse(Author resource) : base(resource) {}
}
