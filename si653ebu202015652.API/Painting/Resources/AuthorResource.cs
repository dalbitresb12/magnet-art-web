using Swashbuckle.AspNetCore.Annotations;

namespace si653ebu202015652.API.Painting.Resources;

public class AuthorResource {
  [SwaggerSchema("Author identifier", ReadOnly = true, Nullable = false)]
  public int Id { get; set; }

  [SwaggerSchema("Author first name", Nullable = false)]
  public string FirstName { get; set; } = string.Empty;

  [SwaggerSchema("Author last name", Nullable = false)]
  public string LastName { get; set; } = string.Empty;

  [SwaggerSchema("Author nickname", Nullable = false)]
  public string Nickname { get; set; } = string.Empty;
}
