using AtaliTicaret.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtaliTicaret.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.CategoryId).UseIdentityColumn();

            builder.Property(c => c.CategoryName).HasMaxLength(50).IsRequired();

            builder.ToTable("Categories");
            builder.Property(c => c.CategoryId).HasColumnName("CategoryId");
            builder.Property(c => c.CategoryName).HasColumnName("CategoryName");

        }
    }
}
