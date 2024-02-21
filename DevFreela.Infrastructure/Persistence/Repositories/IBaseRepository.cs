namespace DevFreela.Infrastructure.Persistence.Repositories
{
    interface IBaseRepository<T> where T : class
    {
        T get(int id);
        List<T> getAll();
        void add(T item);
        void delete(T item);
        void edit(T item);
    }
}