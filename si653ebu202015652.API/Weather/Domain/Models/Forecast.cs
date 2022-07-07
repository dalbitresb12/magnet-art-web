using si653ebu202015652.API.Shared.Domain.Model;

namespace si653ebu202015652.API.Weather.Domain.Models;

public class Forecast : BaseModel {
  public DateTime Date { get; set; }
  public int TemperatureC { get; set; }
  public string? Summary { get; set; }
}
