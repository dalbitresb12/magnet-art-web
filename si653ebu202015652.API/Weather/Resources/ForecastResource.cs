namespace si653ebu202015652.API.Weather.Resources;

public class ForecastResource {
  public long Id { get; set; }
  public DateTime Date { get; set; }
  public int TemperatureC { get; set; }
  public string? Summary { get; set; }
}
