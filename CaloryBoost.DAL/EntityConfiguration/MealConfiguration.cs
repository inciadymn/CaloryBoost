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
    public class MealConfiguration : EntityTypeConfiguration<Meal>
    {
        public MealConfiguration()
        {
            Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
