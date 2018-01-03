using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApplication.Core.Database
{
    public abstract class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity>,IDisposable
        where TEntity : class, new()
        where TContext : DbContext

    {
        //database işlemleri
        protected DbContext _dbContext;
        //tablo işlemleri
        protected IDbSet<TEntity> _dbSet;
        protected bool _disposed = false;
        

        public EFRepositoryBase(DbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public void Add(TEntity model)
        {
            _dbSet.Add(model);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_disposed==false)
                {
                    Dispose();
                    _disposed = true;
                }
            }
        }

        public void Dispose()
        {
            //database bağlantısını kesip kaynakların ram e geri teslimini sağlar.
            _dbContext.Dispose();
            //Garbage Collector bu sınıfı ramden kaldırır.
            GC.SuppressFinalize(this);
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public List<TEntity> List()
        {
            return _dbSet.ToList();
        }

        public void Update(TEntity model)
        {
            var entity = _dbSet.Find(model);
            _dbContext.Entry(entity).CurrentValues.SetValues(model);
            _dbContext.SaveChanges();
        }
    }
}
