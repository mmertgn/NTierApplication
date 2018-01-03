using NTierApplication.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApplication.DAL.ORM.EntityFramework.Configurations
{
    public class CategoryMap: EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            HasIndex<int>(x => x.Id);
            Property(x => x.Name)
                .IsRequired() //IsFixed ise char olmasını sağlar
                .IsUnicode()
                .HasMaxLength(50);  //nvarchar50 not null oldu

            Property(x => x.Name)
                .HasColumnName("Ürünün Kategorisi");

        }
    }
}
