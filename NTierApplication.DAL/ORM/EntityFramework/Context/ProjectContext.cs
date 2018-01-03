using NTierApplication.DAL.ORM.EntityFramework.Configurations;
using NTierApplication.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NTierApplication.DAL.ORM.EntityFramework.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext():base(nameOrConnectionString:"Myconn")
        {
            //herhangi bir model değişikliğinde database tekrar oluştur.
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProjectContext>());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            //tablo isimleri tekillestirme ayarı yani aşağıdaki kod tabloların arkasındaki s takısını alır
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //bir kayıt silinince ilişkili olan diğer tablodaki kayıtlarıda sil
            modelBuilder.Conventions.Add(new OneToManyCascadeDeleteConvention());

        }
    }
}
