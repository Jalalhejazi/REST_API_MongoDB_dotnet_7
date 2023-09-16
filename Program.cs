using MongoDotnetDemo.Models;
using MongoDotnetDemo.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("NoSQLDB"));

builder.Services.AddTransient<ICategoryService,CategoryService>();
builder.Services.AddTransient<IProductService,ProductService>();

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
