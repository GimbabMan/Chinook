using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class EntityData<T> where T: class
    {
        protected ChinookEntities CreateContext()
        {
            ChinookEntities context = new ChinookEntities();
            context.Configuration.ProxyCreationEnabled = false;

            return context;
        }

        public List<T> GetAll()
        {
            ChinookEntities context = CreateContext();

            return context.Set<T>().ToList();
        }

        public int GetCount()
        {
            ChinookEntities context = CreateContext();

            return context.Set<T>().Count();
        }

        public void Insert(T entity)
        {
            ChinookEntities context = CreateContext();

            //context.Albums.Add(album)
            context.Entry(entity).State = EntityState.Added;

            context.SaveChanges();
        }

        public void Update(T entity)
        {
            ChinookEntities context = CreateContext();

            context.Entry(entity).State = EntityState.Modified;

            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            ChinookEntities context = CreateContext();

            context.Entry(entity).State = EntityState.Deleted;

            context.SaveChanges();
        }
    }
}
