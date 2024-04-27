using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calendarWebApp.Models
{
    public class userClass : IdentityUser
    {
        public virtual ICollection<Event> events { get; set; }
    }
}
