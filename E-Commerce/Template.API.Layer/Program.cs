using Microsoft.EntityFrameworkCore;
using Template.API.Layer.Midddleware;
using Template.Core.Layer;
using Template.DAL.Layer.Db;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder
	.Services.AddDbContext<ApplicationDbContext>(options =>
	{
		options.UseNpgsql("Server=localhost;Port=5432;Database=ECommerce;User Id=postgres;Pwd=postgres;");
	});
builder.Services.AddCoreDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseExceptionHandlerMiddleware();

app.UseAuthorization();

app.MapControllers();

app.Run();