using Cars.Models;
using Cars.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Services
{
    public class CarService
    {
        private CarRepository carRepository;

        public CarService(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public List<LicencePlate> GetFilteredList(FilterOption filteroption)
        {
            if (filteroption.Q != null)
            {
                return carRepository.FilterPlates(filteroption.Q);
            }
            else if (filteroption.Police == 1)
            {
                return carRepository.FilterPolice();
            }
            else if (filteroption.Diplomat == 1)
            {
                return carRepository.FilterDiplomat();
            }
            return carRepository.GetPlates();
        }

        public List<LicencePlate> GetCarsByBrand(string brand)
        {
            return carRepository.FilterBrand(brand);
        }
    }
}
