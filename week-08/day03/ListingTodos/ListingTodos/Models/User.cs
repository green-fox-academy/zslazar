using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Models
{
    public class User
    {
        //[Key]
        public int UserId { get; set; }
        public int Name { get; set; }
        public int Email { get; set; }

        ICollection<Todo> todo { get; set; }
    }
}
