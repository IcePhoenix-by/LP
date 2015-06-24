using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPProject.Domain.Abstract;
using LPProject.Domain.Entity;

namespace LPProject.Domain.Abstract
{
   public interface IUnitOfWork
    {
       void SaveChanges();
        IShopRepository Shops { get; }
        IGoodsRepository Goodses { get; }
        void Dispose();
    }
}
