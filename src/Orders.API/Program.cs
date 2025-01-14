var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddHealthChecks();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Order Endpoints

app.MapGet("/orders", () => Results.Ok(new[] { "Order1", "Order2" }));
app.MapGet("/orders/{id}", (int id) => Results.Ok($"Order{id}"));
app.MapPost("/orders", () => Results.Created("/orders/1", "Order1"));
app.MapPut("/orders/{id}", (int id) => Results.NoContent());
app.MapDelete("/orders/{id}", (int id) => Results.NoContent());

// healthcheck Endpoints

app.MapHealthChecks("/health");

app.Run();