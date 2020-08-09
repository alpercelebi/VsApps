using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Vtİslemleri
{
    public class DatabaseService<T> where T:class
    {
        private BlogEntities context = new BlogEntities();

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
        public bool Delete(int id)
        {
            try
            {
                var veri = context.Set<T>().Find(id);
                context.Set<T>().Remove(veri);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public bool Update(T data)
        {
            try
            {
                context.Set<T>().Attach(data);
                context.Entry<T>(data).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool Add(T data)
        {
            try
            {
                context.Set<T>().Add(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
 
        }

 
    }
}