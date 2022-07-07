using System.ComponentModel.DataAnnotations;

namespace si653ebu202015652.API.Weather.Resources;

public class ForecastRequest {
  [Required]
  public DateTime? Date { get; set; }

  [Required]
  public int? TemperatureC { get; set; }

  public string? Summary { get; set; }
}
