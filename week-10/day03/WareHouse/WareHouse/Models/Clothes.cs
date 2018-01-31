using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouse.Models
{
    public class Clothes
    {
        public long Id { get; set; }
        public long ItemName { get; set; }
        public long Manufacturer { get; set; }
        public long Category { get; set; }
        public long Size { get; set; }
        public long UnitPrice { get; set; }
    }
}
