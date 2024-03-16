
using Gym_Management.Core;
using Gym_Management.Middlewares;
using GYM_Management.Core.Models;
using GYM_Management.Core.ServiceModels;
using GYM_Management.Data.DataContext;
using GYM_Management.Data.DataRepository;
using GYM_Management.Servies.ServiceRpository;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var policy = "policy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policy, policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddDbContext<GymData>();

builder.Services.AddScoped<IEquipmentService, EquipmentService>();
builder.Services.AddScoped<IStaffService, StaffService>();
builder.Services.AddScoped<ISubscriberService, SubscriberSevice>();

builder.Services.AddScoped<IEquipment, EquipmentRepository>();
builder.Services.AddScoped<IStaff, StaffRepository>();
builder.Services.AddScoped<ISubscriber, SubscriberRepository>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(policy);

app.UseMiddleware<ShabbatMiddleware>();

app.MapControllers();

app.Run();
