using Microsoft.EntityFrameworkCore;
namespace DevFreela.Infrastructure.Persistence.Repositories
{
    public class BaseRepository<T>
         : IDisposable, IBaseRepository<T> where T : class
    {


        private readonly DevFreelaDbContext _context;

        public BaseRepository(DevFreelaDbContext devFreelaDbContext)
        {
            _context = devFreelaDbContext;
        }


        public T get(int id)
        {
            
            return _context.Set<T>().Find(id);

        }

        public List<T> getAll()
        {
            return _context.Set<T>().ToList();

        }

        public void add(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public void delete(T item)
        {
            _context.Set<T>().Remove(item);
            _context.Entry(item).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void edit(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }



}