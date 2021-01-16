using AtaliTicaret.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtaliTicaret.DataAccess.Concrete.EntityFramework.Mapping
{
    public class DealerMap : IEntityTypeConfiguration<Dealer>
    {
        public void Configure(EntityTypeBuilder<Dealer> builder)
        {
            builder.HasKey(c => c.DealerId);
            builder.Property(c => c.DealerId).UseIdentityColumn();

            builder.Property(c => c.DealerName).HasMaxLength(150).IsRequired();
            builder.Property(c => c.DealerTel).HasMaxLength(20).IsRequired();
            builder.Property(c => c.DealerAdress).HasMaxLength(250).IsRequired();
            builder.Property(c => c.DealerLogoUrl).HasMaxLength(250).IsRequired();

            builder.ToTable("Dealers");
            builder.Property(c => c.DealerId).HasColumnName("DealerId");
            builder.Property(c => c.DealerName).HasColumnName("DealerName");
            builder.Property(c => c.DealerTel).HasColumnName("DealerTel");
            builder.Property(c => c.DealerAdress).HasColumnName("DealerAdress");
            builder.Property(c => c.DealerLogoUrl).HasColumnName("DealerLogoUrl");
        }
    }
}
