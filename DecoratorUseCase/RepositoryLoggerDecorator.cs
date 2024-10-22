namespace DecoratorUseCase;

public class RepositoryLoggerDecorator(IRepository repository, ILogger<RepositoryLoggerDecorator> logger) : RepositoryDecorator(repository)
{
    private readonly ILogger<RepositoryLoggerDecorator> _logger = logger;
    public override Task<Weather> GetById(int id)
    {
        var entity = base.GetById(id);
        _logger.LogInformation($"Fetched entity: {entity}");
        return entity;
    }
}