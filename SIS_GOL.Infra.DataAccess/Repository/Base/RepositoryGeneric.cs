using Microsoft.EntityFrameworkCore;
using SIS_GOL.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIS_GOL.Infra.DataAccess
{
    public class RepositoryGeneric<TEntity> : IReading<TEntity>, IRecording<TEntity>, IDisposable where TEntity : class
    {
        private readonly DbContextOptionsBuilder<GOL_Connection> _conn;
        public RepositoryGeneric()
        {
            _conn = new DbContextOptionsBuilder<GOL_Connection>();
        }
        public async Task Create(TEntity entity)
        {
            using (var con = new GOL_Connection(_conn.Options))
            {
                await con.Set<TEntity>().AddAsync(entity);
                await con.SaveChangesAsync();
            }
        }

        public async Task Delete(long id)
        {
            using (var con = new GOL_Connection(_conn.Options))
            {
                var ent = await con.Set<TEntity>().FindAsync(id);
                con.Set<TEntity>().Remove(ent);
                await con.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<TEntity>> FindAll()
        {
            using (var con = new GOL_Connection(_conn.Options))
            {
              
                return await con.Set<TEntity>().AsNoTracking().ToListAsync();
            }
        }

        public  Task<TEntity> FindOne(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> FindOne(long id)
        {
            using (var con = new GOL_Connection(_conn.Options))
            {
                return await con.Set<TEntity>().FindAsync(id);
            }
        }

        public async Task<IEnumerable<TEntity>> FindwithParameters(Expression<Func<TEntity, bool>> filter)
        {
            using (var con = new GOL_Connection(_conn.Options))
            {
                return await con.Set<TEntity>().AsNoTracking().ToListAsync();
            }
        }

        public async Task Update(TEntity entity)
        {
            using (var con = new GOL_Connection(_conn.Options))
            {
                con.Entry<TEntity>(entity).State = EntityState.Modified;
                await con.SaveChangesAsync();
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool isDispose)
        {
            if (!isDispose) return;

        }
    }
}
