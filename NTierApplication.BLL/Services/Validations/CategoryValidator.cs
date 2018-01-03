using FluentValidation;
using NTierApplication.DAL.ORM.EntityFramework.Context;
using NTierApplication.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApplication.BLL.Services.Validations
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori Adi Boş Geçilemez");
            RuleFor(x => x.Name).Must(CategoryMustNotExist).WithMessage("Bu kategori daha önce girildi");
        }

        public bool CategoryMustNotExist(string categoryname)
        {
            using (ProjectContext context = new ProjectContext())
            {
              return !context.Categories.Any(x => x.Name == categoryname);
            }
        }
    }
}
