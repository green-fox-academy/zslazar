using System.Collections.Generic;
using WareHouse.Models;

namespace WareHouse.ViewModels
{
    public class ClothesViewModel
    {
        public List<string> Sizes { get; set; }
        public List<string> ItemNames { get; set; }
        public List<Clothes> Clothes { get; set; }
    }
}
