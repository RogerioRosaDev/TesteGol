using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIS_GOL.Domain
{
   public interface IReading<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> FindAll();
        Task<IEnumerable<TEntity>>FindwithParameters(Expression<Func<TEntity, bool>> filter);
        Task <TEntity> FindOne (Expression<Func<TEntity, bool>> filter);
        Task<TEntity> FindOne(long id);
    }
}
