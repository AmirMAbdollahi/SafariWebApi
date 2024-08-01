using Microsoft.EntityFrameworkCore;
using Safari.Api.Interfaces;
using Safari.Api.Services;
using Safari.Data.DbContext;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SafariDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("Safari"));
});
builder.Services.AddScoped<IMartyrService, MartyrService>();
builder.Services.AddScoped<ICommentService, CommentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();