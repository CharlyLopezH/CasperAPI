using CasperAPI.Entidades;

namespace CasperAPI.Repositorios
{
    public interface IRepositorioAdscripciones
    {
        Task<int> Actualizar(Adscripcion adscripcion);
        Task Borrar(int id);
        Task<int> Crear(Adscripcion adscripcion);
        Task<bool> Existe(int id);
        Task<Adscripcion?> ObtenerPorId(int id);
        Task<List<Adscripcion>> ObtenerTodas();
    }
}