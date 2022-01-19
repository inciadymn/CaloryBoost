using CaloryBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryBoost.DAL.EntityConfiguration
{
    class UserMealFoodConfiguration : EntityTypeConfiguration<UserMealFood>
    {
        public UserMealFoodConfiguration()
        {
            Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.CreatedDate)
                .IsRequired();

            Property(a => a.Portion)
                .IsRequired();

            HasRequired(a => a.User)
                .WithMany(a => a.UserMealFoods)
                .HasForeignKey(a => a.UserID);

            HasRequired(a => a.Food)
                .WithMany(a => a.UserMealFoods)
                .HasForeignKey(a => a.FoodID);

            HasRequired(a => a.Meal)
                .WithMany(a => a.UserMealFoods)
                .HasForeignKey(a => a.MealID);
        }
    }
}
