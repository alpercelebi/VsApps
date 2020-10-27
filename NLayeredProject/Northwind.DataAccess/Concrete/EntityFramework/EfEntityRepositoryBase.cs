using Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> 
        where TEntity:class ,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext nesne = new TContext())
            {
                var entitydefault = nesne.Entry(entity);
                entitydefault.State = EntityState.Added;
                nesne.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext nesne = new TContext())
            {
                var entitydefault = nesne.Entry(entity);
                entitydefault.State = EntityState.Deleted;
                nesne.SaveChanges();
            }
        }

        public TEntity Get(int id)
        {
            using (TContext nesne = new TContext())
            {
                return nesne.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetAll()
        {
            using (TContext nesne = new TContext())
            {
                return nesne.Set<TEntity>().ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext nesne = new TContext())
            {
                var entitydefault = nesne.Entry(entity);
                entitydefault.State = EntityState.Modified;
                nesne.SaveChanges();
            } 
        }
    }
}
