using GestionProductos.Models;
using GestionProductos.Services;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecific = "_myAllowSpecific";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProductosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("connectionDB"))
    );
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecific, policy =>
    {
        policy.WithOrigins("http://localhost:3000")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
    });
});
// Add services to the container.
builder.Services.AddScoped<IProductosService, ProductosService>();
builder.Services.AddScoped<IVentasServices, VentasServices>();
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecific);
app.UseAuthorization();

app.MapControllers();

app.Run();
