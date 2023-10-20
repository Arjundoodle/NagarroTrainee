using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static WebApplication1.Views.Shared.Enum;

namespace WebApplication1.Views.Shared
{
   
        public class Event
        {

            public int EventId { get; set; }


            public string Title { get; set; }
            public DateTime Date { get; set; }
            public string Location { get; set; }
            public DateTime StartTime { get; set; }
            public EventType? Type { get; set; }
            public float? Duration { get; set; }
            public string Description { get; set; }
            public string OtherDetails { get; set; }
            public string InviteByEmail { get; set; }
            public string UserId { get; set; }
            public virtual User User { get; set; }


            public virtual ICollection<Invitation> Invitations { get; set; }
            public virtual ICollection<Comment> Comments { get; set; }
        }
    }



