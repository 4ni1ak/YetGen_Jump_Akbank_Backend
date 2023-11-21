using _015._01_HashingAndFluentApi.Api.Services;
using HashingAndFluentApi.Persistence.Configurations;
using HashingAndFluentApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<FakeDataService>();

builder.Services.AddMemoryCache();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(ConfigurationsDb.GetString("ConnectionStrings:PostgreSQL")
);
});
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
