using Microsoft.EntityFrameworkCore;
using WebAPI.Pizza.Ui.Infrastructure.Database;
using WebAPI.Pizza.UI.ExtensionsMethod;

var builder = WebApplication.CreateBuilder(args);
//var stringConnection = builder.Configuration.GetConnectionString("PizzaConnection");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#region Ajout des DbContext
//builder.Services.AddDbContext<PizzaDbContext>(options => options.UseSqlServer(stringConnection));
builder.Services.AddAllDbContext(builder.Configuration);
#endregion

#region Ajout Injection Layer et repository
builder.Services.AddAllinjection();
#endregion

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
