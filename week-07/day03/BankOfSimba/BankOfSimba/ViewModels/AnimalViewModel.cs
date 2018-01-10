using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;

namespace BankOfSimba.ViewModels
{
    public class AnimalViewModel
    {
        public List<BankAccount> AnimalList { get; set; } = new List<BankAccount>();

        public AnimalViewModel()
        {
            InitAnimalList();
        }

        private void InitAnimalList()
        {
            AnimalList.Add(new BankAccount("Simba", 2000, "lion"));
            AnimalList.Add(new BankAccount("Nala", 2200, "lion"));
            AnimalList.Add(new BankAccount("Rafiki", 5000, "monkey"));
        }
    }
}
