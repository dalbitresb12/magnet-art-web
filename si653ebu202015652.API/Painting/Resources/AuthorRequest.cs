using System.ComponentModel.DataAnnotations;

namespace si653ebu202015652.API.Painting.Resources;

public class AuthorRequest {
  [Required]
  public string? FirstName { get; set; }

  [Required]
  public string? LastName { get; set; }

  [Required]
  public string? Nickname { get; set; }

  public string? PhotoUrl { get; set; }
}
