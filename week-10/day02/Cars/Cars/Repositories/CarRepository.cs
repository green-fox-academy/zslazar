using Cars.Entities;
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repositories
{
    public class CarRepository
    {
        private CarContext carContext;

        public CarRepository(CarContext carContext)
        {
            this.carContext = carContext;
        }

        public List<LicencePlate> GetPlates()
        {
            return carContext.LicencePlates.ToList();
        }

        public List<LicencePlate> FilterPlates(string q)
        {
            return carContext.LicencePlates.Where(l => l.Plate.Contains(q)).ToList();
        }

        public List<LicencePlate> FilterPolice()
        {
            return carContext.LicencePlates.Where(l => l.Plate.StartsWith("RB")).ToList();
        }

        public List<LicencePlate> FilterDiplomat()
        {
            return carContext.LicencePlates.Where(l => l.Plate.StartsWith("DT")).ToList();
        }

        public List<LicencePlate> FilterBrand(string brand)
        {
            return carContext.LicencePlates.Where(l => l.Plate.Equals(brand)).ToList();
        }

    }
}
