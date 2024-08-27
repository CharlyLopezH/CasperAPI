using CasperAPI.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CasperAPI.Repositorios
{
    public class RepositorioAdscripciones(ApplicationDBContext context) : IRepositorioAdscripciones
    {
        private readonly ApplicationDBContext context = context;

        public async Task<int> Crear(Adscripcion adscripcion)
        {
            context.Add(adscripcion);
            await context.SaveChangesAsync();
            return (adscripcion.Id);
        }
        public async Task<List<Adscripcion>> ObtenerTodas()
        {
            return await context.Adscripciones.OrderBy(a => a.Nombre).ToListAsync();
        }
        public async Task<Adscripcion?> ObtenerPorId(int id)
        {
            return await context.Adscripciones.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Adscripciones.AnyAsync(a => a.Id == id);
        }

        public async Task<int> Actualizar(Adscripcion adscripcion)
        {
            context.Update(adscripcion);
            await context.SaveChangesAsync();
            return (adscripcion.Id); //Experimental
        }
        public async Task Borrar(int id)
        {
            await context.Adscripciones.Where(a => a.Id == id).ExecuteDeleteAsync();
        }
    }

}
