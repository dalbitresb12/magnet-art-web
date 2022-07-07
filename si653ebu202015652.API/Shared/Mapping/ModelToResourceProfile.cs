using AutoMapper;
using si653ebu202015652.API.Weather.Mapping;

namespace si653ebu202015652.API.Shared.Mapping;

public class ModelToResourceProfile : Profile {
  public ModelToResourceProfile() {
    ForecastModelToResourceProfile.Register(this);
  }
}
