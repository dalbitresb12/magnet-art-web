using si653ebu202015652.API.Shared.Domain.Model;

namespace si653ebu202015652.API.Painting.Domain.Models;

public class Author : BaseModel {
  public string FirstName { get; set; } = string.Empty;
  public string LastName { get; set; } = string.Empty;
  public string Nickname { get; set; } = string.Empty;
  public string? PhotoUrl { get; set; }
}
