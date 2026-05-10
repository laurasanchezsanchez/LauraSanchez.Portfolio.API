var builder = WebApplication.CreateBuilder(args);

// Add controllers to handle API endpoints
builder.Services.AddControllers();

// Add OpenAPI (Swagger) support
builder.Services.AddOpenApi();

// Add CORS policy to allow the frontend to call this API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        // Allow any origin, header and method for now
        // Restrict to the real domain when deployed
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Enable OpenAPI only in development environment
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Redirect HTTP to HTTPS
app.UseHttpsRedirection();

// Apply the CORS policy
app.UseCors("AllowFrontend");

// Enable authorization middleware
app.UseAuthorization();

// Map controller routes
app.MapControllers();

app.Run();