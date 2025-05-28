using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PedidoPackingAPI.Data; // Para usar AppDbContext

var builder = WebApplication.CreateBuilder(args);

// Configura o EF Core com SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adiciona suporte a controllers (API REST)
builder.Services.AddControllers();

// Adiciona suporte ao Swagger (OpenAPI)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// ✅ Executa automaticamente as migrations ao iniciar a API
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate(); // Cria o banco de dados se ainda não existir
}

// Middleware do Swagger (visível em http://localhost:8080/swagger)
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Mapeia os endpoints dos controllers
app.MapControllers();

app.Run();
