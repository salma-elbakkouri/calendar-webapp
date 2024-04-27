using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace calendarWebApp.Models
{
    public class Event
    {
        public int id { get; set; }
        public String name { get; set; }
        public String desc { get; set; }
        public bool reached  { get; set; }
        public DateTime date { get; set; }

        [ForeignKey("userClass")]
        public string id_user { get; set; }
        public virtual userClass applicationIdentity { get; set; }

        public Event()
        {

        }
    }
}
