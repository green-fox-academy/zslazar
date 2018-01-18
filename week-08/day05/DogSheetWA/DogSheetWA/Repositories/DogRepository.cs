﻿using DogSheetWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
