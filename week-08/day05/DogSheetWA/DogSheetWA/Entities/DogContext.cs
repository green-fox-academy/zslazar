﻿using DogSheetWA.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DogSheetWA
{
    public class DogContext : DbContext
    {
        public DogContext(DbContextOptions<DogContext> options) : base(options)
        {
        }

        public DbSet<Sheet> SheetData { get; set; }
    }
}
