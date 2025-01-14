var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddHealthChecks();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Product Endpoints

app.MapGet("/products", () => Results.Ok(new[] { "Product1", "Product2" }));
app.MapGet("/products/{id}", (int id) => Results.Ok($"Product{id}"));
app.MapPost("/products", () => Results.Created("/products/1", "Product1"));
app.MapPut("/products/{id}", (int id) => Results.NoContent());
app.MapDelete("/products/{id}", (int id) => Results.NoContent());

// Categories Endpoint

app.MapGet("/products/categories", () => Results.Ok(new[] { "Electronics", "Books", "Clothing", "Food" }));

// healthcheck Endpoints

app.MapHealthChecks("/health");

app.Run();
