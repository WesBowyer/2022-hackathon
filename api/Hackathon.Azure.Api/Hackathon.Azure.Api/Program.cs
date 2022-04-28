using System.IdentityModel.Tokens.Jwt;
using Hackathon.Azure.Api.Services;
using Hackathon.Azure.Api.Services.Interfaces;
using Microsoft.Identity.Web;

var configurationRoot = new ConfigurationBuilder().Build();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMicrosoftIdentityWebApiAuthentication(configurationRoot);
builder.Services.AddSingleton<JwtSecurityTokenHandler>();
builder.Services.AddSingleton<ITokenHandler, TokenHandler>();

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
