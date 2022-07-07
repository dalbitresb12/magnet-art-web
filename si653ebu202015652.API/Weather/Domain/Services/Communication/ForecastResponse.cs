using si653ebu202015652.API.Shared.Domain.Service.Communication;
using si653ebu202015652.API.Weather.Domain.Models;

namespace si653ebu202015652.API.Weather.Domain.Services.Communication;

public class ForecastResponse : BaseResponse<Forecast> {
  public ForecastResponse(string message) : base(message) {}
  public ForecastResponse(Forecast resource) : base(resource) {}
}
