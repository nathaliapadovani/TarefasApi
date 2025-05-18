using Microsoft.EntityFrameworkCore;
using TarefasApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o suporte aos controladores
builder.Services.AddControllers();

// Adiciona o DbContext ao cont�iner de servi�os
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("DataSource=tarefas.db;Cache=Shared"));

// Configura��o do Swagger apenas no ambiente de desenvolvimento
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

// Configura��es do pipeline de requisi��es HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tarefas API v1");
        c.RoutePrefix = string.Empty; // Define o Swagger como p�gina inicial
    });
}

// app.UseHttpsRedirection(); // Comentei para evitar problemas de redirecionamento
app.MapControllers();

app.Run();