using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
