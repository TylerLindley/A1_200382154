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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Animal>().HasData(
                new Models.Animal() { Id = 10, Name = "Tyler The Tiger", Description = "He's GREAT" },
                new Models.Animal() { Id = 11, Name = "Cody The Chipmunk",Description = "He Climbs Stuff"}
                );

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Food>().HasData(
                new Models.Food() { Id = 10, Price = 30, Name = "Petsy Dog Food", Description = "Average Dog Food", NutritionalInformation = "120 calories, full of vitamins A/B/C/D", Weight = 20, Brand = "Petsy", TypeOfAnimalFor = "Dog" },
                new Models.Food() { Id = 11, Price = 4331, Name = "Louis Vuitton Cat Caviar", Description = "Best Cat Caviar on the Market", NutritionalInformation = "1 Calorie, 0 Carbs, 0 Sugar, 0 fats", Weight = 15, Brand = "Louis Vuitton", TypeOfAnimalFor = "Cat", }
                );
        } 

    }
}
