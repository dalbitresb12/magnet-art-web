using si653ebu202015652.API.Shared.Domain.Repositories;
using si653ebu202015652.API.Training.Domain.Models;
using si653ebu202015652.API.Training.Domain.Repositories;
using si653ebu202015652.API.Training.Domain.Services;
using si653ebu202015652.API.Training.Domain.Services.Communication;

namespace si653ebu202015652.API.Training.Services;

public class ProviderService : IProviderService {
  private readonly IProviderRepository repository;
  private readonly IUnitOfWork unitOfWork;

  public ProviderService(IProviderRepository repository, IUnitOfWork unitOfWork) {
    this.repository = repository;
    this.unitOfWork = unitOfWork;
  }

  public async Task<Provider?> GetById(int id) {
    return await repository.FindById(id);
  }

  public async Task<ProviderResponse> Create(Provider request) {
    if (request.KeyRequired && string.IsNullOrEmpty(request.ApiKey)) {
      return new ProviderResponse("The API Key cannot be blank when the key is required.");
    }

    try {
      var providerWithName = await repository.FindByName(request.Name);

      if (providerWithName is not null) {
        return new ProviderResponse("There's another provider registered with the same name.");
      }

      var providerWithApiUrl = await repository.FindByApiUrl(request.ApiUrl);

      if (providerWithApiUrl is not null) {
        return new ProviderResponse("There's another provider registered with the same API URL.");
      }

      await repository.Add(request);
      await unitOfWork.Complete();
      return new ProviderResponse(request);
    } catch (Exception e) {
      return new ProviderResponse($"An error occurred while saving the provider: {e.Message}");
    }
  }
}
