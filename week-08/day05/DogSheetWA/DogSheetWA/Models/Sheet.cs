using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogSheetWA.Models;

namespace DogSheetWA.Models
{
    public class Sheet
    {
        public long Id { get; set; }
        public string Handler { get; set; }
        public string Dog { get; set; }
        public string Specialization { get; set; }
        public double Level { get; set; }
        public double Score { get; set; }
    }

    
}
