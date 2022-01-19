using CaloryBoost.DAL.EntityConfiguration;
using CaloryBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.DAL
{
    public class CaloryBoostDbContext : DbContext
    {
        public CaloryBoostDbContext() : base("Server=.; Database=CaloryBoostDb; uid=sa; pwd=as")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<UserMealFood> UserMealFoods { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new FoodConfiguration());
            modelBuilder.Configurations.Add(new FoodCategoryConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new UserMealFoodConfiguration());
            
        }
    }
}
