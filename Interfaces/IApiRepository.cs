using System.Threading.Tasks;
using System.Collections.Generic;
using TPInvestigacion.Clases;

namespace TPInvestigacion.Interfaces
{
    public interface IApiRepository
    {
        void Add<T> (T entity) where T: class; 
        void Delete<T> (T entity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<Moto>> GetMotosAsync();
        Task<Moto> GetMotoByIdAsync(int id);
        Task<Moto> GetMotoByPatenteAsync(string patente);
    }
}
