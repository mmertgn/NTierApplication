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
    public class CategoryRepository : EFRepositoryBase<Category, ProjectContext>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
