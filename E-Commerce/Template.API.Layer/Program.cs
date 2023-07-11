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
		options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
	});
builder.Services.AddCoreDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseExceptionHandlerMiddleware();

app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();
