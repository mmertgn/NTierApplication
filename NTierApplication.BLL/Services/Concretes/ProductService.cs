using NTierApplication.BLL.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierApplication.BLL.Dtos;
using NTierApplication.Entity.Entities;
using NTierApplication.BLL.Services.Validations;
using NTierApplication.Repository.Repositories.Abstracts;
using NTierApplication.Core.Infrastructure.Messaging.Abstracts;

namespace NTierApplication.BLL.Services.Concretes
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMessaging _messageService;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductService(IProductRepository productRepo,IMessaging messageService)
        {
            _productRepository = productRepo;
            _messageService = messageService;
           
        }

        public ResultModel<Product> ProductSave(Product model)
        {
            var validator = new ProductValidator().Validate(model);

            if (validator.IsValid)
            {
                _productRepository.Add(model);

                if (_messageService!=null)
                {
                    MessageTemplate m = new MessageTemplate();
                    m.From = "mert.alptekin@wissenakademie.com";
                    m.To = new List<string>();
                    m.To.Add("mert.alptekin@neominal.com");
                    m.MessageBody = "Yazilim16 Deneme";
                    m.MessageSubject = "Test";

                    _messageService.SendMessage(m);
                }

                return new ResultModel<Product>
                {
                    Errors = null,
                    IsValid = true,
                    Message = "Kayıt Başarılı"
                };
            }

            return new ResultModel<Product>
            {
                Errors = validator.Errors.Select(x => x.ErrorMessage).ToList(),
                IsValid = false,
                Message = "Kayıt Başarısız"
            };
        }
    }
}
