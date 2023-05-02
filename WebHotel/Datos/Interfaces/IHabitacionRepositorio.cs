using Modelos;

namespace Datos.Interfaces
{
    public interface IHabitacionRepositorio
    {
        Task<bool> Nuevo(Habitacion habitacion);
        Task<bool> Actualizar(Habitacion habitacion);
        Task<bool> Eliminar(int codigo);
        Task<IEnumerable<Habitacion>> GetLista();
        Task<Habitacion> GetPorCodigo(int codigo);

    }
}