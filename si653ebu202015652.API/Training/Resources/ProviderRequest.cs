using System.ComponentModel.DataAnnotations;

namespace si653ebu202015652.API.Training.Resources;

public class ProviderRequest {
  [Required]
  public string? Name { get; set; }

  public string? ApiUrl { get; set; }

  public bool KeyRequired { get; set; } = false;

  public string? ApiKey { get; set; }
}
