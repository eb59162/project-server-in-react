using Dal.Data;
using Microsoft.EntityFrameworkCore;
using ProjectReactServer;
using ProjectReactServer.Models;
using System.Configuration;
  string MyCors = "_MyCors";

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<ProjectContext>(op => op.UseSqlServer("Data Source=LAB-D-06;Initial Catalog=ProjectServerClient;Integrated Security=SSPI;Trusted_Connection=True;"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//הרשאות גישה---
builder.Services.AddCors(op =>
{
    op.AddPolicy(MyCors,
        builder =>
        {
            builder.WithOrigins("*")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});
builder.Services.AddScoped<IPhotosItnterface, PhotosClass>();
builder.Services.AddScoped<IUserInterface, UsersClass>();
builder.Services.AddScoped<IPostsInterface, PostsClass>();
builder.Services.AddScoped<IToDointerface, ToDoClass>();
var app = builder.Build();
//view/other windows-
//Add-Migration InitialCreate
//Update-Database



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(MyCors);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
