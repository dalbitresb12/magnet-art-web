using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace si653ebu202015652.API.Training.Resources;

public class ProviderRequest {
  [Required]
  [SwaggerSchema("Provider name")]
  public string? Name { get; set; }

  [SwaggerSchema("Provider API URL")]
  public string? ApiUrl { get; set; }

  [SwaggerSchema("Set if the API Key is required")]
  public bool KeyRequired { get; set; } = false;

  [SwaggerSchema("Provider API Key")]
  public string? ApiKey { get; set; }
}
