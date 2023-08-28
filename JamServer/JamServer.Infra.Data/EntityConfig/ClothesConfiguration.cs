using JamServer.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Infra.Data.EntityConfig
{
    public class ClothesConfiguration : IEntityTypeConfiguration<Clothes>
    {
        public void Configure(EntityTypeBuilder<Clothes> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Size).HasMaxLength(50).IsRequired();

            builder.HasOne(x => x.Athlete).WithMany(x => x.Clothes).HasForeignKey(x => x.AtlheteId);

           /* builder.HasData(
                new Clothes(1, "Shirt", "T-Shirt de correr", "S"),
                new Clothes(2, "Shirt", "T-Shirt de correr", "M"),
                new Clothes(3 , "Shirt", "T-Shirt de correr", "L"));*/
        }
    }
}
