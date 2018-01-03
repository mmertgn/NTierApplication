using NTierApplication.BLL.Dtos;
using NTierApplication.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApplication.BLL.Services.Abstracts
{
    public interface ICategoryService
    {
        ResultModel<Category> Create(Category model); 
    }
}
