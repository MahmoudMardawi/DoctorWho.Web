using DoctorWho.Db.Contexts;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using FluentValidation.AspNetCore;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using DoctorWho.Db.Domain.Dtos;
using DoctorWho.Db.Profiles;
using DoctorWho.Db.Domain.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers().AddFluentValidation(c => c.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


IConfiguration configuration = new ConfigurationBuilder()
   .AddJsonFile("appsettings.json", true,true)
   .Build();


builder.Services.AddMvc();
builder.Services.AddAutoMapper(typeof(DoctorWhoCoreDbContext));
var mapperConfig = new MapperConfiguration(mc => {
    mc.AddProfile(new DoctorProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

string myDb1ConnectionString = configuration.GetConnectionString("myDb1");


builder.Services.AddDbContext<DoctorWhoCoreDbContext>(options => options
.UseSqlServer(myDb1ConnectionString));
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.Run();
