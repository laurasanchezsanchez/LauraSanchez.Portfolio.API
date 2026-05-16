using LauraSanchez.Portfolio.API.Middleware;
using LauraSanchez.Portfolio.API.Repositories;
using LauraSanchez.Portfolio.API.Repositories.Interfaces;
using LauraSanchez.Portfolio.API.Services;
using LauraSanchez.Portfolio.API.Services.Interfaces;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// OpenAPI
builder.Services.AddOpenApi();

// Dependency injection — scoped per request
builder.Services.AddScoped<IPortfolioRepository, JsonPortfolioRepository>();
builder.Services.AddScoped<IPortfolioService, PortfolioService>();

// CORS — allow any origin for now
// TODO: restrict to real domain when deployed 
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

// Global exception handler — must be first in the pipeline
app.UseMiddleware<ExceptionMiddleware>();

app.UseHttpsRedirection();
app.UseCors("AllowFrontend");
app.UseAuthorization();
app.MapControllers();

app.Run();