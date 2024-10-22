namespace DecoratorUseCase;

public abstract class RepositoryDecorator(IRepository repository) : IRepository
{
    private readonly IRepository _repository = repository;

    public virtual Task<Weather> GetById(int id)
    {
        return _repository.GetById(id);
    }
}