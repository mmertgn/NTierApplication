using FluentValidation;
using NTierApplication.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApplication.BLL.Services.Validations
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürünün adını girmek zorundasınız");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Fiyat 0 olamaz");
            //RuleFor(x => x.Price).Must(Kural).WithMessage("Kurala Uymuyor");
            //RuleFor(x=> x).Must(KompleksKural);

        }

        public bool Kural(decimal fiyat)
        {
            //database bağlanıp kural kontrol edilir ve ona göre validasyon koşuluna girer.
            return true;
        }

        //birden fazla alana tek bir kurala bağlamak için ise modelin kendisini parametre olarak gönderebilir ve && || koşulu ile kriter oluşturabiliriz.

        public bool KompleksKural(Product model)
        {
            if (model.Name=="A" || model.Price>10 )
            {
                return true;
            }

            return false;
        }

    }
}
