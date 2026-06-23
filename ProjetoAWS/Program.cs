using Scalar.AspNetCore;

{
  "ConnectionStrings": {
    "BDClientes": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDClientes;Integrated Security=True"
  }
}
builder.Services.AddControllers();
builder.Services.AddOpenApi(); // <-- Corrigido aqui (estava ?.lder)

builder.Services.AddMemoryCache();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapOpenApi();

app.UseSwagger(); 
app.UseSwaggerUI();

app.MapScalarApiReference(s => s.WithTheme(ScalarTheme.BluePlanet));

app.UseAuthorization();
app.MapControllers();
app.Run();
