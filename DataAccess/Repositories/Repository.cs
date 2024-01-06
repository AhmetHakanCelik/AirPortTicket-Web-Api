using DataAccess.DbContext;
using Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Repositories
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entities, CancellationToken cancellationToken = default)
        {
             await _context.Set<T>().AddAsync(entities, cancellationToken);
        }

        public IQueryable<T> GetAll()
        {
            return  _context.Set<T>().AsQueryable();
        }

        public async Task<T> GetByIdAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
        {
            var response =await _context.Set<T>().Where(expression).FirstOrDefaultAsync(expression, cancellationToken); 
            return response;
        }

        public IEnumerable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).ToList();
        }

        public void Remove(T entities)
        {
            _context.Set<T>().Remove(entities);
        }

        public void Update(T entities)
        {
            _context.Set<T>().Update(entities);
        }
    }
}
