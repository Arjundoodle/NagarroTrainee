using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Views.Shared
{
    public class User
    {
        public string UserName { get; set; }

        public string EmailId { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
