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
            AnimalList.Add(new BankAccount("Simbaaaa", 2000.00, "lion"));
            AnimalList.Add(new BankAccount("Nala", 2200, "lion"));
            AnimalList.Add(new BankAccount("Rafiki", 5000, "monkey"));

            //AnimalList.Add(new BankAccount()
            //{
            //    Name = "Simba",
            //    Balance = 2000.00,
            //    AnimalType = "lion",
            //});

        }
    }
}