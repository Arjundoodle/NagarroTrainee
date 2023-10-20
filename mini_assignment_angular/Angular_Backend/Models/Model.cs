using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Backend.Models
{
    public class Model
    {
        [Key]
        public int  UserId { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }
    }
}
