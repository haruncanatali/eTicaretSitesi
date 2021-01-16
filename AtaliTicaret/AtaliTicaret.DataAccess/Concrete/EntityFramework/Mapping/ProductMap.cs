using AtaliTicaret.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtaliTicaret.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c => c.ProductId);
            builder.Property(c => c.ProductId).UseIdentityColumn();

            builder.Property(c => c.ProductName).HasMaxLength(50).IsRequired();
            builder.Property(c => c.ProductTitle).HasMaxLength(50).IsRequired();
            builder.Property(c => c.ProductDescription).HasMaxLength(350);
            builder.Property(c => c.ProductPhotoUrl).HasMaxLength(200).IsRequired();

            builder.ToTable("Products");
            builder.Property(c => c.ProductId).HasColumnName("ProductId");
            builder.Property(c => c.ProductName).HasColumnName("ProductName");
            builder.Property(c => c.ProductTitle).HasColumnName("ProductTitle");
            builder.Property(c => c.ProductDescription).HasColumnName("ProductDescription");
            builder.Property(c => c.ProductPrice).HasColumnName("ProductPrice");
            builder.Property(c => c.ProductPhotoUrl).HasColumnName("ProductPhotoUrl");
        }
    }
}
