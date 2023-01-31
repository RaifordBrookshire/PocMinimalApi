using PocMinimalApi.Endpoints;
using PocMinimalApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add Dependencies & Build App
builder.Services.AddTransient<GlobalExceptionHandler>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
//app.UseGlobalException()
//app.Use<GlobalException>;
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

// Map Endpoint Group
var api = app.MapGroup("/api");

// Map Endpoints - NOTE: No code, Only Configuration to keep it Clean
api.MapGet("/test", () => "Test Success");
api.MapGet("/basic", BasicEnpoint.Handler);
api.MapGet("/user",  UserEndpoint.Handler);
api.MapPost("/login", AuthenticationEndpoint.LoginHandler);
// api.MapPost("/logout", AuthenticationEndpoint.LogoutHandler).RequireAuthentication();
api.MapPost("/register", AuthenticationEndpoint.LogoutHandler);
api.MapGet("/health", HealthEndpoint.Handler);
api.MapGet("/weatherforecast", WeatherEndpoint.Handler).WithName("GetWeather").WithOpenApi();

// Start the Web Server Listening
app.Run();








