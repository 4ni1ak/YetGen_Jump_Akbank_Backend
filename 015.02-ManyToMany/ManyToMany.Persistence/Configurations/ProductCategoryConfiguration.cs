﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManyToMany.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManyToMany.Persistence.Configurations
{
    internal class ProductCategoryConfiguration:IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => new { x.CategoryId, x.ProductId });
            
            //Relationships
            builder.HasOne<Product>(x => x.Product)
                .WithMany(x => x.ProductCategories)
                .HasForeignKey(x => x.ProductId);
            builder.HasOne<Category>(x=>x.Category)
                .WithMany(x => x.ProductCategories)
                .HasForeignKey(x => x.CategoryId);

            // CreatedByUserId
            builder.Property(x => x.CreatedByUserId).IsRequired();
            builder.Property(x => x.CreatedByUserId).HasMaxLength(75);

            // CreatedOn
            builder.Property(x => x.CreatedOn).IsRequired();


            builder.ToTable("ProductCategories");
        }
    }
}
