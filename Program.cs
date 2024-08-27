using CasperAPI;
using CasperAPI.Endpoints;
using CasperAPI.Entidades;
using CasperAPI.Repositorios;
using CasperAPI.Servicios;
using Microsoft.EntityFrameworkCore;
using System;
var builder = WebApplication.CreateBuilder(args);

//var ambiente = builder.Configuration.GetValue<string>("ambiente");
//Variable para la cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//Servicios
builder.Services.AddDbContext<ApplicationDBContext>(opciones => 
opciones.UseSqlServer("name=DefaultConnection"));

//Importante respetar esta posición
builder.Services.AddOutputCache();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Servicios de Repositorios
builder.Services.AddScoped<IRepositorioEmpleados, RepositorioEmpleados>();
builder.Services.AddScoped<IRepositorioAdscripciones, RepositorioAdscripciones>();

builder.Services.AddScoped<IAlmacenadorArchivos, AlmacenadorArchivos>();
builder.Services.AddHttpContextAccessor();

builder.Services.AddAutoMapper(typeof(Program));
//Final área servicios

var app = builder.Build();

//middlewares
app.UseSwagger();
app.UseSwaggerUI();


//app.MapGet("/", () => "Hello World! ");

//Endpoints con MapGroup
app.MapGroup("/empleados").MapEmpleados();
app.MapGroup("/adscripciones").MapAdscripciones();

//Fin de los middlewares
app.Run();
