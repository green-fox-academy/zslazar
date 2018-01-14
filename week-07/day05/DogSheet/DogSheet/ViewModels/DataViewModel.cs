using DogSheet.Models;
using System.Collections.Generic;

namespace DogSheet.ViewModels
{
    public class DataViewModel
    {
        public List<Data> Participants { get; set; } = new List<Data>();

        public DataViewModel()
        {
            InitAnimalList();
        }

        private void InitAnimalList()
        {
            Participants.Add(new Data()
            {
                Handler = "Zsuska",
                Dog = "Lili",
                Specialization = "Obedience",
                Level = 3,
                Score = 89,
            });
        }
    }
}
