using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Domain.Services;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Data.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<DbAppContext>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IGetUserRepository, UserRepository>();
builder.Services.AddScoped<ITaskRepository, TaskRepository>();


builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IGetUserService, UserService>();
builder.Services.AddScoped<ITaskService, TaskService>();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
    options.JsonSerializerOptions.WriteIndented = true;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();