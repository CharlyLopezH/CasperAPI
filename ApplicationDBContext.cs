using CasperAPI.Entidades;
//using CasperAPI.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Reflection.Emit;

namespace CasperAPI
{
    public class ApplicationDBContext(DbContextOptions options) : DbContext(options)
    {
        //Definición de tablas para la DB
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Adscripcion> Adscripciones { get; set; }

        //Configuración del Fluent API para cambios y ajustes en propiedades de tablas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        // modelBuilder.Entity<Adscripcion>()
        //.HasMany(a => a.Empleados) // Propiedad de navegación en Adscripcion
        //.WithOne(e => e.Adscripcion) // Propiedad de navegación en Empleado
        //.HasForeignKey(e => e.AdscripcionId) // Clave foránea en Empleado
        //.IsRequired(); // Establece que la relación es obligatoria
        }


    }

}
