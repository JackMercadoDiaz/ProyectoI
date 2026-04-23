
using ProyectoI.Entidades;
using ProyectoI.Servicios;
using ProyectoI.Servicios.Interfaces;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container. Nuestras interfaces y servicios
builder.Services.AddScoped<IReserva, ReservaServicios>();
builder.Services.AddScoped<IHorario, HorarioServicios>();
builder.Services.AddScoped<ICliente, ClienteServicios>();
builder.Services.AddScoped<IBloqueo, BloqueoServicios>();
builder.Services.AddScoped<ISeccion, SeccionServicios>();
builder.Services.AddScoped<IZona, ZonaServicios>();


builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
