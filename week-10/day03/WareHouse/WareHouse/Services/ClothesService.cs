using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouse.Models;
using WareHouse.Repositories;

namespace WareHouse.Services
{
    public class ClothesService
    {
        private ClothesRepository clothesRepository;

        public ClothesService(ClothesRepository clothesRepository)
        {
            this.clothesRepository = clothesRepository;
        }

        public List<Clothes> GetClothes()
        {
            return clothesRepository.GetAllClothes();
        }
    }
}
