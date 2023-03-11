using RR.Domain.DbModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;

namespace RR.Domain.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetAsync(Expression<Func<T, bool>> expression, List<string> includes = null);
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null);
        Task InsertAsync(T entity);
        Task InsertRangeAsync(IEnumerable<T> entities);
        Task DeleteAsync(int id);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);

        Task SaveChangesAsync();
    }
}
