//1. Using to work with EF
using Microsoft.EntityFrameworkCore;
using Mundo_disney.DataAccess;

var builder = WebApplication.CreateBuilder(args);

//2. Todo: Connection With SQL
const string CONNECTIONNAME = "DisneyDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

//3. Add context to services of builder
builder.Services.AddDbContext<DisneyDBContext>(op =>
    op.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
