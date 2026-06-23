using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos Serviços (Injeção de Dependência)
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddMemoryCache();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuração do Pipeline de Requisições (Middlewares)
app.MapOpenApi();
app.UseSwagger();
app.UseSwaggerUI();

// Configuração do Scalar (Interface da API)
app.MapScalarApiReference(s => s.WithTheme(ScalarTheme.BluePlanet));

app.UseAuthorization();
app.MapControllers();

app.Run();