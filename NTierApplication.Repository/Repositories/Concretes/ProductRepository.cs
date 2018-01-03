using NTierApplication.Core.Database;
using NTierApplication.DAL.ORM.EntityFramework.Context;
using NTierApplication.Entity.Entities;
using NTierApplication.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NTierApplication.Repository.Repositories.Concretes
{
    public class ProductRepository : EFRepositoryBase<Product, ProjectContext>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
          
        }

        public List<Product> GetProductsByCategoryId(int Id)
        {
            return _dbSet.Where(x => x.CategoryId == Id).ToList();
        }

        //sadece interfaceden gelen methodlar var ise bunun kodlarını yazmam lazım.
    }
}
