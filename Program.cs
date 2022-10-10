//1. Using to work with EF
using Microsoft.EntityFrameworkCore;
using Mundo_disney.DataAccess;
using Mundo_disney.Models.DataModels;
using Mundo_disney.Services;

var builder = WebApplication.CreateBuilder(args);

//2. Todo: Connection With SQL
const string CONNECTIONNAME = "DisneyDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

//3. Add context to services of builder
builder.Services.AddDbContext<DisneyDBContext>(op =>
    op.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();

//4. Add services to aplication
builder.Services.AddScoped<IUsersServices, UsersServices>();
//builder.Services.AddScoped<IUsersServices, UsersServices>();
//builder.Services.AddScoped<IUsersServices, UsersServices>();
//builder.Services.AddScoped<IUsersServices, UsersServices>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//5. Cors Configuration
builder.Services.AddCors(op =>
{
    op.AddPolicy(name: "CorsPolicy", builder =>
    {
        //Cualquier origen o aplicacion puede hacer peticion.
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});


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

//6. Tell app to cors(uso de cors)
app.UseCors("CorsPolicy");

app.Run();
