using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPProject.Domain.Abstract;
using LPProject.Domain.Context;
using LPProject.Domain.Entity;
using LPProject.Domain.Repository;

namespace LPProject.Domain.Concrete
{
   public class UnitOfWork:IUnitOfWork,IDisposable
    {
        public UnitOfWork()
        {
            CreateDbContext();
        }
        private EfDbContext DbContext { get; set; }
        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }
       
       public IShopRepository Shops
        {
            get { return new ShopRepository(DbContext); }
        }

        public IGoodsRepository Goodses
        {
            get { return new GoodsRepository(DbContext); }
        }
      
        protected void CreateDbContext()
        {
            DbContext = new EfDbContext();
            DbContext.Configuration.ProxyCreationEnabled = false;
            DbContext.Configuration.LazyLoadingEnabled = false;
            DbContext.Configuration.ValidateOnSaveEnabled = false;
        }

       public void Dispose()
       {
           DbContext.Dispose();
       }
    }
}
