using Microsoft.EntityFrameworkCore;
using api_Proyecto.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<splash_dataContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CadenaSql")));

builder.Services.AddControllers().AddJsonOptions(opt =>
{ opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; });

var ReglasCorsDefinidas = "Reglas";
builder.Services.AddCors(option => option.AddPolicy(name: ReglasCorsDefinidas,
    builder => {
        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    }

    )
);



var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
  
//}

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(ReglasCorsDefinidas); //politica cors para uso de apis

app.UseAuthorization();

app.MapControllers();

app.Run();
