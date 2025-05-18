using Microsoft.EntityFrameworkCore;
using TarefasApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o suporte aos controladores
builder.Services.AddControllers();

// Adiciona o DbContext ao contêiner de serviços
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("DataSource=tarefas.db;Cache=Shared"));

// Configuração do Swagger apenas no ambiente de desenvolvimento
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
        {
            Title = "Tarefas API",
            Version = "v1"
        });
    });
}

var app = builder.Build();

// Configurações do pipeline de requisições HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tarefas API v1");
        c.RoutePrefix = string.Empty; // Define o Swagger como página inicial
    });
}

// app.UseHttpsRedirection(); // Comentei para evitar problemas de redirecionamento
app.MapControllers();

app.Run();