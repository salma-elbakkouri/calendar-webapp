using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using calendarWebApp.Models;

namespace calendarWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<userClass>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<calendarWebApp.Models.Event> Event { get; set; }
       
    }
}
