using ThirdProject.Database;
using ThirdProject.Repositories;
using ThirdProject.Repositories.Interfaces;
using ThirdProject.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<DatabaseContext>();
builder.Services.AddTransient<DatabaseContext>();
builder.Services.AddTransient<TaskService>();
builder.Services.AddTransient<ITaskRepository, TaskRepository>();
builder.Services.AddDbContext<DatabaseContext>();

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
