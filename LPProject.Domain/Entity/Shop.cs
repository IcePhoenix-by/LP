using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPProject.Domain.Entity
{
   public class Shop:Base
    {
        public string Address { get; set; }
        public string TimeOfWork { get; set; }
        public IEnumerable<Goods> Goodses { get; set; }
    }
}
