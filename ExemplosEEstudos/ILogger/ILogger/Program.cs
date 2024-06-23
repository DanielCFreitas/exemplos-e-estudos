using ILoggerExemplo.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Adiciona as configuracoes de logs personalizadas
builder.Logging.AddLoggingConfiguration();

// Adiciona as dependencias da aplicacao
builder.Services.AddDependencyInjectionConfiguration();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
