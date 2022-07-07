using AutoMapper;
using si653ebu202015652.API.Painting.Mapping;
using si653ebu202015652.API.Training.Mapping;

namespace si653ebu202015652.API.Shared.Mapping;

public class ResourceToModelProfile : Profile {
  public ResourceToModelProfile() {
    PaintingResourceToModelProfile.Register(this);
    TrainingResourceToModelProfile.Register(this);
  }
}
