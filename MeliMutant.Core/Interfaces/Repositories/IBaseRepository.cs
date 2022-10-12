using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Core.Interfaces.Repositories
{

        public interface IBaseRepository<TEntity> where TEntity : class
        {
            ValueTask<TEntity> GetByIdAsync(int id);
            Task<IEnumerable<TEntity>> GetAllAsync();
            Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null,
                                                    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                                    string includeProperties = "");
            Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
            Task AddAsync(TEntity entity);
            Task AddRangeAsync(IEnumerable<TEntity> entities);
            void Remove(TEntity entity);
            void RemoveRange(IEnumerable<TEntity> entities);
            void Update(TEntity entityToUpdate);
            void UpdateRange(IEnumerable<TEntity> entitiesToUpdate);
        }
    }

