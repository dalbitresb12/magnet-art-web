namespace si653ebu202015652.API.Weather.Domain.Repositories;

public interface IUnitOfWork {
  Task Complete();
}
