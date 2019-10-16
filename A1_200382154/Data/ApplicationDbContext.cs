using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using A1_200382154.Models;

namespace A1_200382154.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<A1_200382154.Models.Food> Food { get; set; }
        public DbSet<A1_200382154.Models.Animal> Animal { get; set; }
    }
}
