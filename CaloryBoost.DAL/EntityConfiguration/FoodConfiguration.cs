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
    public class FoodConfiguration: EntityTypeConfiguration<Food>
    {
        public FoodConfiguration()
        {
            Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(a => a.Calory)
                .IsRequired();

            Property(a => a.FoodTypes)
                .IsRequired();

            Property(a => a.Description)
                .IsRequired();  

            Property(a => a.Portion)
                .IsRequired();

            Property(a => a.PortionTypes)
                .IsRequired();

            //Relation
            HasRequired(a => a.FoodCategory)
                .WithMany(a => a.Foods)
                .HasForeignKey(a => a.FoodCategoryID);
        }
    }
}
