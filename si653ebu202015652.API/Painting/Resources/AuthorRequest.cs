using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace si653ebu202015652.API.Painting.Resources;

public class AuthorRequest {
  [Required]
  [SwaggerSchema("Author first name")]
  public string? FirstName { get; set; }

  [Required]
  [SwaggerSchema("Author last name")]
  public string? LastName { get; set; }

  [Required]
  [SwaggerSchema("Author nickname")]
  public string? Nickname { get; set; }

  [SwaggerSchema("Author photo URL")]
  public string? PhotoUrl { get; set; }
}
