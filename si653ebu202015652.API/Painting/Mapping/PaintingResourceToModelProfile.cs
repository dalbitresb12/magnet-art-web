using AutoMapper;
using si653ebu202015652.API.Painting.Domain.Models;
using si653ebu202015652.API.Painting.Resources;

namespace si653ebu202015652.API.Painting.Mapping;

public static class PaintingResourceToModelProfile {
  public static void Register(IProfileExpression profile) {
    profile.CreateMap<AuthorRequest, Author>();
  }
}
