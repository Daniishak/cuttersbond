var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ❌ INGEN UseRouting()
// ❌ INGEN UseHttpsRedirection()

app.MapGet("/ping", () => "pong");
app.MapControllers();

app.Run();
