var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddHealthChecks();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Order Endpoints

app.MapGet("/orders", () => Results.Ok(new[] { new { Name = "Order 1" }, new { Name = "Order 2" } }));
app.MapGet("/orders/{id}", (int id) => Results.Ok(new { Name = $"Order {id}" }));
app.MapPost("/orders", () => Results.Created("/orders/1", new { Name = "Order 1" }));
app.MapPut("/orders/{id}", (int id) => Results.NoContent());
app.MapDelete("/orders/{id}", (int id) => Results.NoContent());

// healthcheck Endpoints

app.MapHealthChecks("/health");

app.Run();