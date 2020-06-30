using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerryApi.Models
{

    public class AckberryContext : IdentityDbContext
    {
        public AckberryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ToDoItem> ToDoItem { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
