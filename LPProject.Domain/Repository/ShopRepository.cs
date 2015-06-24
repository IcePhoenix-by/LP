using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPProject.Domain.Abstract;
using LPProject.Domain.Context;
using LPProject.Domain.Entity;

namespace LPProject.Domain.Repository
{
    internal class ShopRepository : BaseRepository<Shop>, IShopRepository, IDisposable

    {

       

        public ShopRepository(DbContext DbContext1)
            : base(DbContext1)
        {
          
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }

        public void GetGoodsShop()
        {
            
        }
    }

}
