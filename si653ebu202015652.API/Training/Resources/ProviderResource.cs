using Swashbuckle.AspNetCore.Annotations;

namespace si653ebu202015652.API.Training.Resources;

public class ProviderResource {
  [SwaggerSchema("Provider identifier", ReadOnly = true, Nullable = false)]
  public int Id { get; set; }

  [SwaggerSchema("Provider name", Nullable = false)]
  public string Name { get; set; } = string.Empty;

  [SwaggerSchema("Provider identifier", Nullable = false)]
  public string? ApiUrl { get; set; }

  [SwaggerSchema("Check if the API Key is required", Nullable = false)]
  public bool KeyRequired { get; set; } = false;

  [SwaggerSchema("Provider API Key", Nullable = false)]
  public string? ApiKey { get; set; }
}
