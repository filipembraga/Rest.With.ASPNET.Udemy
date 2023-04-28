using _02___Person.REST.Business.Implementations;
using _02___Person.REST.Business.Interfaces;
using _02___Person.REST.Model.Context;
using _02___Person.REST.Repository.Implementations;
using _02___Person.REST.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApiVersioning();
builder.Services.AddScoped<IPersonBusiness, PersonBusiness>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();

var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"]; 

builder.Services.AddDbContext<MySqlContext>(options => 
    options.UseMySql(connection, new MySqlServerVersion("7,0,0")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
