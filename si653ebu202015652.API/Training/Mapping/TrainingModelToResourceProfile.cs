using AutoMapper;
using si653ebu202015652.API.Training.Domain.Models;
using si653ebu202015652.API.Training.Resources;

namespace si653ebu202015652.API.Training.Mapping;

public static class TrainingModelToResourceProfile {
  public static void Register(IProfileExpression profile) {
    profile.CreateMap<Provider, ProviderResource>();
  }
}
