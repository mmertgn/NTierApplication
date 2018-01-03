using NTierApplication.BLL.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierApplication.BLL.Dtos;
using NTierApplication.Entity.Entities;
using NTierApplication.Repository.Repositories.Abstracts;
using NTierApplication.BLL.Services.Validations;

namespace NTierApplication.BLL.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;

        public CategoryService(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public ResultModel<Category> Create(Category model)
        {
            var validator = new CategoryValidator().Validate(model);

            if (validator.IsValid)
            {
                _categoryRepo.Add(model);

                return new ResultModel<Category>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Kategori Eklendi!"
                };
            }

            return new ResultModel<Category>
            {
                Errors = validator.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Başarısız"
            };

        }
    }
}
