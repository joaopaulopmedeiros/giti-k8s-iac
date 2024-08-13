using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiServices();
builder.Services.AddHealthChecks();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapHealthChecks("/health");

app.MapGet("/purchases", async (
    [AsParameters] PurchaseSearchRequest request,
    [FromServices] PurchaseService service) => await service.SearchAsync(request))
.WithOpenApi();

await app.RunAsync();
