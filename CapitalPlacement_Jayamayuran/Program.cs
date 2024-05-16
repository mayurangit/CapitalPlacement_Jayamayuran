using CapitalPlacement_Jayamayuran.Data;
using CapitalPlacement_Jayamayuran.Repository.Interface;
using CapitalPlacement_Jayamayuran.Repository.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string conn_string = "AccountEndpoint=https://localhost:8081/;AccountKey=C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
string db = "CPExamDB";
builder.Services.AddDbContext<CPAppDbContext>(option=>option.UseCosmos(conn_string, db));

builder.Services.AddScoped<InterfaceProgram, IServiceProgram>();
builder.Services.AddScoped<InterfaceQuestion, IServiceQuestion>();
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
