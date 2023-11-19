using DIAndDInjection.Api.Services;
using DIAndDInjection.Shared;
using DIAndDInjection.Shared.Services;
using DIAndDInjection.Shared.Utilities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<RequestCountService>(new RequestCountService());

builder.Services.AddSingleton<PasswordGenerator>();

var textPath = builder.Configuration.GetSection("TextPath").Value;
//builder.Services.AddSingleton<ITextService, TextService>(x=>new TextService(textPath));
builder.Services.AddSingleton<ITextService, TextService>(x=>new TextService());

builder.Services.AddSharedServices();



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
