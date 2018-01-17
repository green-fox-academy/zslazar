﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos
{
    public class Todo
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsUrgent { get; set; } = false;
        public bool IsDone { get; set; } = false;
        public string Date { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }
}
