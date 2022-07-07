using si653ebu202015652.API.Shared.Domain.Model;

namespace si653ebu202015652.API.Training.Domain.Models;

public class Provider : BaseModel {
  public string Name { get; set; } = string.Empty;
  public string? ApiUrl { get; set; }
  public bool KeyRequired { get; set; } = false;
  public string? ApiKey { get; set; }
}
