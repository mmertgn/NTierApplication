using NTierApplication.Core.Database;
using NTierApplication.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApplication.Repository.Repositories.Abstracts
{
    public interface IProductRepository:IRepository<Product>
    {
        //ek methodlar database işlemleri insert,update,delete,list dışındaki işlemler buraya yazılacaktır.

        List<Product> GetProductsByCategoryId(int Id);
        
    }
}
