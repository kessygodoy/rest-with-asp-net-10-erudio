using RestWithASPNET10Erudio.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//singleton significa que a mesma instância do serviço será usada durante toda a vida útil da aplicação
builder.Services.AddSingleton<MathService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
