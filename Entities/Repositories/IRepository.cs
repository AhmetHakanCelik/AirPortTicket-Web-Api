using System.Linq.Expressions;

namespace Entities.Repositories
{
    public interface IRepository<T>
    {
        Task AddAsync(T entities, CancellationToken cancellationToken = default);
        void Update(T entities);
        void Remove(T entities);
        Task<T> GetByIdAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
        IEnumerable<T> GetWhere(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetAll();
    }
}
