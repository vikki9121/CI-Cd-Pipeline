var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// GET UTC 11 good  time workhiiii sabb
app.MapGet("time/utc", () => Results.Ok(DateTime.UtcNow));

await app.RunAsync();
