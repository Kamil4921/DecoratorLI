using DecoratorUseCase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("InMemDatabase"));
builder.Services.AddScoped<IRepository>(p =>
{
    var context = p.GetService<AppDbContext>();
    var logger = p.GetService<ILogger<RepositoryLoggerDecorator>>();

    var repo = new Repository(context);
    var decoratedRepo = new RepositoryLoggerDecorator(repo, logger);
    return decoratedRepo;
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/weather", async (IRepository repository) => await repository.GetById(1))
    .WithName("GetWeather")
    .WithOpenApi();

app.Run();