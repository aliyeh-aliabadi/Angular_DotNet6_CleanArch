

using Microsoft.EntityFrameworkCore;
using SimCarTel.Dashboard.Api.Hubs;
using SimCarTel.Dashboard.Application.Interfaces;
using SimCarTel.Dashboard.Application.Services;
using SimCarTel.Dashboard.Data.Context;
using SimCarTel.Dashboard.Data.Repositories;
using SimCarTel.Dashboard.Data.Repositories.Base;
using SimCarTel.Dashboard.Domian.Interfaces.Repositories;
using SimCarTel.Dashboard.Domian.Interfaces.Repositories.Base;
using SimCarTel.Dashboard.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection"));
});

DependencyContainer.RegisterServices(builder.Services);


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

app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
app.UseHttpsRedirection();


app.UseAuthorization();

app.MapHub<NotificationHub>("/notificationHub");

app.MapControllers();

app.Run();
