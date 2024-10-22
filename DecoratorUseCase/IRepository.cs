namespace DecoratorUseCase;

public interface IRepository
{
    Task<Weather> GetById(int id);
}