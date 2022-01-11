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
    public class UserConfiguration: EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            Property(a => a.LastName)
              .IsRequired()
              .HasMaxLength(100);

            Property(a => a.Password)
                .IsRequired()
                .HasMaxLength(20);

            Property(a => a.Email)
              .IsRequired()
              .HasMaxLength(100);

            HasIndex(a => a.Email)
                .IsUnique(); //unique yapıldı 

            Property(a => a.BirthDate)
              .IsRequired();

            Property(a => a.Gender)
                .IsRequired();

        }
    }
}
