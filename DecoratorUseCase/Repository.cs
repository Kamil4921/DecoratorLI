using Microsoft.EntityFrameworkCore;

namespace DecoratorUseCase;

public class Repository(AppDbContext context) : IRepository
{
    private readonly AppDbContext _context = context;

    public async Task<Weather> GetById(int id)
    {
        return await _context.Weather.Where(x=> x.Id == id).FirstOrDefaultAsync();
    }
}