using Microsoft.EntityFrameworkCore;
using TPInvestigacion.Clases;

namespace TPInvestigacion.Interfaces
{
    public class ApiRepository : IApiRepository
    {
        public readonly DataContext _context;

        public ApiRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Moto> GetMotoByIdAsync(int id)
        {
            var moto= await _context.Motos.FirstOrDefaultAsync(u => u.Id == id);
            return moto;
        }

        public async Task<Moto> GetMotoByPatenteAsync(string patente)
        {
            var moto= await _context.Motos.FirstOrDefaultAsync(u => u.patente == patente);
            return moto;
        }

        public async Task<IEnumerable<Moto>> GetMotosAsync()
        {
            var moto = await _context.Motos.ToListAsync();
            return moto;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
