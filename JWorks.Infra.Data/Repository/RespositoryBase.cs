using System;
using System.Collections.Generic;
using JWorks.Domain.Interface.Repository;
using JWorks.Infra.Data.Repository;
using System.Data.Entity;

namespace JWorks.Infra.Data.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        worksDBEntities dB = new worksDBEntities();

        public void Add(TEntity obj)
        {
            dB.Set<TEntity>().Add(obj);
            dB.SaveChanges();
        }

        public void Dispose()
        {
            dB.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dB.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return dB.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            dB.Set<TEntity>().Remove(obj);
            dB.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            dB.Entry(obj).State = EntityState.Modified;
            dB.SaveChanges();
        }
    }
}
