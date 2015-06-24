using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPProject.Domain.Entity;

namespace LPProject.Domain.Context
{
   public class EfDbContext :DbContext
    {
       public DbSet<Goods> Goodses { get; set; }
       public DbSet<Shop> Shops { get; set; }
    }
}
