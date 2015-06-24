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
    class GoodsRepository:BaseRepository<Goods>,IGoodsRepository,IDisposable
    {
        protected IEnumerable<Goods> DbSet { get; set; }
        public GoodsRepository(DbContext DbContext)
            : base(DbContext)
        {
        }

        public void Dispose()
        {
           DbContext.Dispose();
        }
    }
}
