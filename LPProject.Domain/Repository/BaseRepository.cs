using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPProject.Domain.Abstract;

namespace LPProject.Domain.Repository
{
   public class BaseRepository<T>:IBaseRepository<T> where T:class 
   {
        protected DbContext DbContext { get; set; }
        protected DbSet<T> DbSet { get; set; }

       public BaseRepository(DbContext DbContext)
        {
            this.DbContext = DbContext;
            DbSet = this.DbContext.Set<T>();
        }

       public IEnumerable<T> GetAll()
        {
            return DbSet;
        }

       public T Get(int id)
       {
           return DbSet.Find(id);
       }

       public T Find(int id)
       {
           return (DbSet.Find(id));
       }

       public void Add(T item)
       {
           DbSet.Add(item);
       }

       public void Remove(T item)
       {
           DbSet.Remove(item);
       }

       public void Update(T item)
       {
           DbContext.Entry(item).State = EntityState.Modified;
       }
   }
}
