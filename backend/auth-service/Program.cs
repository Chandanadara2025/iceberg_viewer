var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IAuthService, AuthService>(); // Ensure this exists
builder.Services.AddControllers();
var app = builder.Build();
app.UseAuthorization();
app.MapControllers();
app.Run();
