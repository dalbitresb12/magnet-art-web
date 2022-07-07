namespace si653ebu202015652.API.Training.Resources;

public class ProviderResource {
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string? ApiUrl { get; set; }
  public bool KeyRequired { get; set; } = false;
  public string? ApiKey { get; set; }
}
