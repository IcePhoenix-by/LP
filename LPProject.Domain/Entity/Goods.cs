using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPProject.Domain.Entity
{
    public class Goods:Base
    {
        public string Description { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
