using System.Linq.Expressions;

namespace Entities.Repositories
{
    public interface IRepository<T>
    {
        Task AddAsync(T entities, CancellationToken cancellationToken = default);
        void Update(T entities);
        void Remove(T entities);
        Task<T> GetByIdAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAll();
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
    }
}
