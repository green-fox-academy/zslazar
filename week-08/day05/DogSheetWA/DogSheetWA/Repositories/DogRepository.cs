using DogSheetWA.Models;
using System.Collections.Generic;
using System.Linq;

namespace DogSheetWA.Repositories
{
    public class DogRepository
    {
        public DogContext dogContext;

        public DogRepository(DogContext dogContext)
        {
            this.dogContext = dogContext;
        }
        
        public List<Sheet> ReturnList()
        {
            return dogContext.SheetData.ToList();
        }

        public void CreateNewItem(Sheet sheet)
        {
            dogContext.SheetData.Add(sheet);
            dogContext.SaveChanges();
        }

        public void DeleteItem(long index)
        {
            Sheet data = dogContext.SheetData.FirstOrDefault(x => x.Id == index);
            dogContext.SheetData.Remove(data);
            dogContext.SaveChanges();
        }

        public Sheet GetItem(long index)
        {
            return dogContext.SheetData.FirstOrDefault(x => x.Id == index);
        }

        public void EditItem(Sheet sheet, long index)
        {
            Sheet data = dogContext.SheetData.FirstOrDefault(x => x.Id == index);
            data.Handler = sheet.Handler;
            data.Dog = sheet.Dog;
            data.Specialization = sheet.Specialization;
            data.Level = sheet.Level;
            data.Score = sheet.Score;
            dogContext.SaveChanges();
        }
    }
}
