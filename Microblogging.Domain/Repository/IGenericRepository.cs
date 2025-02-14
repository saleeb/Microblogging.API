

namespace Microblogging.Domain.Repository;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    Task<List<T>> FindAsync(Func<IQueryable<T>, IQueryable<T>> query);
}
