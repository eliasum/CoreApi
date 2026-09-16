var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/status", () => new 
{ 
    Status = "Healthy", 
    Timestamp = DateTime.UtcNow 
});

app.Run();