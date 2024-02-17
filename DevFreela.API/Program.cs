using DevFreela.Application.Services.Implementations;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//Dependency Injections
builder.Services.AddScoped<DevFreelaDbContext>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<ISkillService, SkillService>();

builder.Services.AddSwaggerGen();

var config = builder.Configuration;

var connectionString = config.GetConnectionString("DevFreelaDBCS");
var sqlServerVersion = new MySqlServerVersion(new Version(8, 3, 0));

builder.Services.AddDbContext<DevFreelaDbContext>(opt =>
    opt.UseMySql(connectionString, sqlServerVersion)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

