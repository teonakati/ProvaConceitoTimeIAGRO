using Catalog.Repository;
using Catalog.Repository.Interface;
using Catalog.Service;
using Catalog.Service.Interface;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

    opt.IncludeXmlComments(xmlFullPath);
});

builder.Services.AddSingleton<Context>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IShippingService, ShippingService>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
