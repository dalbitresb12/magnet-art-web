namespace si653ebu202015652.API.Shared.Domain.Repositories;

public interface IUnitOfWork {
  Task Complete();
}
