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
    class FoodCategoryConfiguration : EntityTypeConfiguration<FoodCategory>
    {
        public FoodCategoryConfiguration()
        {
            Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100);


            //HasMany(a => a.Foods)
            //    .WithRequired(a => a.FoodCategory)
            //    .HasForeignKey(a => a.FoodCategoryID);
        }
    }
}
