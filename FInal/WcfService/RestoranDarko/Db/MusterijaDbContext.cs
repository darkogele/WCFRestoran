using RestoranDarko.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestoranDarko.Db
{
    public class MusterijaDbContext:DbContext
    {
        public MusterijaDbContext() : base("MusterijaDbContext")
        {

        }
        public DbSet<Musterija> Musterija { get; set; }
        public DbSet<Food>Food { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Order> Order { get; set; }
    }

   public  class MusterijaDbInitializzer : DropCreateDatabaseIfModelChanges<MusterijaDbContext>
    {
        protected override void Seed(MusterijaDbContext context)
        {
            
            context.Musterija.Add(new Musterija() { Name = "Darko", Address = "Petar Deljan",
            Rating = 5, Order ="Vafli", Comment="BE FAST IM STARVING DAMMIT!"});
            context.SaveChanges();

            context.Food.Add(new Food() { Name = "Peperoni Pizza", Price = 350 });
            context.Food.Add(new Food() { Name = "Rebro", Price = 150 });
            context.Food.Add(new Food() { Name = "Pekinska Patka", Price = 1350 });
            context.Food.Add(new Food() { Name = "Ekler", Price = 30 });
            context.Food.Add(new Food() { Name = "Corba", Price = 120 });

            context.Ingredient.Add(new Ingredient() { Name="Brokula", Description="Zdravo od prirodata ide kako dopuna so mnogu jadenja"});
            context.Ingredient.Add(new Ingredient() { Name = "Majonez", Description = "Vkusen dodatok na vasata Naracka" });
            context.Ingredient.Add(new Ingredient() { Name = "Piperka", Description = "Pikantno ljuta otvara apetit " });
            context.Ingredient.Add(new Ingredient() { Name = "Brokula", Description = "Zdravo od prirodata ide kako dopuna so mnogu jadenja" });

            //context.Order.Add(new Order() { Customer="Darko", Food="Rebro", Price=150});

        }
    }
}

