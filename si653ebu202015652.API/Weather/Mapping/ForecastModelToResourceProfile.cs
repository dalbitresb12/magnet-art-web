using AutoMapper;
using si653ebu202015652.API.Weather.Domain.Models;
using si653ebu202015652.API.Weather.Resources;

namespace si653ebu202015652.API.Weather.Mapping;

public static class ForecastModelToResourceProfile {
  public static void Register(IProfileExpression profile) {
    profile.CreateMap<Forecast, ForecastResource>();
  }
}
