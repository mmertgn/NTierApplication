using NTierApplication.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApplication.DAL.ORM.EntityFramework.Configurations
{
    public class ProductMap:EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey<int>(x => x.Id);
            Property(x => x.Name).HasMaxLength(100);
            //null geçilebilir.
            Property(x => x.Price).IsOptional();
            Property(x => x.Stock).IsRequired();

            //category ile product arasında bire çok ilişki var fakat categoryıd foreign key alanı zorunlu alan değil boş geçilebilir.

            HasOptional(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);



        }
    }
}
