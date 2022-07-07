using si653ebu202015652.API.Weather.Domain.Models;

namespace si653ebu202015652.API.Weather.Domain.Repositories;

public interface IForecastRepository {
  Task<IEnumerable<Forecast>> ListAll();

  Task Add(Forecast forecast);

  Task<Forecast?> FindById(long id);

  void Update(Forecast forecast);

  void Remove(Forecast forecast);
}
