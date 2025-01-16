var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddHealthChecks();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Product Endpoints

app.MapGet("/products", () => Results.Ok(new[] { new { Name = "Product 1" }, new { Name = "Product 2" } }));
app.MapGet("/products/{id}", (int id) => Results.Ok(new { Name = $"Product {id}" }));
app.MapPost("/products", () => Results.Created("/products/1", new { Name = "Product 1" }));
app.MapPut("/products/{id}", (int id) => Results.NoContent());
app.MapDelete("/products/{id}", (int id) => Results.NoContent());

// Categories Endpoint

app.MapGet("/products/categories", () => Results.Ok(new[]
{
    new { Name = "Electronics" },
    new { Name = "Books" },
    new { Name = "Clothing" },
    new { Name = "Food" }
}));

// healthcheck Endpoints

app.MapHealthChecks("/health");

app.Run();
