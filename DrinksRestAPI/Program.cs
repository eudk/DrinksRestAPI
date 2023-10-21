using DrinksRepositoryLib;

// nuget packages needed: Microsoft.AspNetCore.OpenApi and Swashbuckle.AspNetCo
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options => // CORS is required for the frontend to access the API
{
    options.AddPolicy(name: "AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
}); // this part is used for the swagger documentation and is not required for the API to work




builder.Services.AddControllers();
builder.Services.AddSingleton<DrinksRepository>(new DrinksRepository()); // <-- Add this line to register the DrinksRepository


builder.Services.AddEndpointsApiExplorer(); // <-- Add this line 
builder.Services.AddSwaggerGen(); // <-- Add this line 

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment()) // used for swagger 
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();

app.UseCors("AllowAll"); // CORS is required for the frontend to access the API


app.MapControllers();

app.Run();