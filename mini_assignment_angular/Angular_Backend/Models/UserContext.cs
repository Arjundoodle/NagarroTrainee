using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Backend.Models
{
    public class UserContext:DbContext
    {

        public UserContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Model> Users { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Agreement>   Agreements { get; set; }
    }
}
