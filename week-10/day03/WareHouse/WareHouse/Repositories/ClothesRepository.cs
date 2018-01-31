using System.Collections.Generic;
using System.Linq;
using WareHouse.Entities;
using WareHouse.Models;

namespace WareHouse.Repositories
{
    public class ClothesRepository
    {
        private ClothesContext clothesContext;

        public ClothesRepository(ClothesContext clothesContext)
        {
            this.clothesContext = clothesContext;
        }

        public List<Clothes> GetAllClothes()
        {
            return clothesContext.WarehouseDB.ToList();
        }

        public Clothes GetNameAndSize(string name, string size)
        {
            return clothesContext.WarehouseDB.FirstOrDefault(x => x.ItemName.Equals(name) && x.Size.Equals(size));
        }

        public List<Clothes> GetTypeDependOnPrice(double price, string type)
        {
            List<Clothes> FilteredList = new List<Clothes>();

            if (type.Equals("lower"))
            {
                FilteredList = GetAllClothes().Where(f => f.UnitPrice < price).ToList();
            }
            else if (type.Equals("higher"))
            {
                FilteredList = GetAllClothes().Where(f => f.UnitPrice > price).ToList();
            }
            else if (type.Equals("equal"))
            {
                FilteredList = GetAllClothes().Where(f => f.UnitPrice == price).ToList();
            }
            return FilteredList;
        }

    }
}
