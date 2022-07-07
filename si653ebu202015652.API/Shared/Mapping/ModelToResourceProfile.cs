using AutoMapper;
using si653ebu202015652.API.Painting.Mapping;
using si653ebu202015652.API.Training.Mapping;

namespace si653ebu202015652.API.Shared.Mapping;

public class ModelToResourceProfile : Profile {
  public ModelToResourceProfile() {
    PaintingModelToResourceProfile.Register(this);
    TrainingModelToResourceProfile.Register(this);
  }
}
