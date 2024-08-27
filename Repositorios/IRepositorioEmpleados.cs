using CasperAPI.Entidades;

namespace CasperAPI.Repositorios
{
    public interface IRepositorioEmpleados
    {
        Task<int> Crear(Empleado empleado);
        Task<List<Empleado>> ObtenerTodos();
        Task<Empleado?> ObtenerPorId(int id);        
        Task Actualizar(Empleado empleado);
        Task Borrar(int id);
        Task<bool> Existe(int id);
        

    }
}
