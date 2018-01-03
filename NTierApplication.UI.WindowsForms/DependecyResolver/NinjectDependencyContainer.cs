using Ninject;
using NTierApplication.BLL.Services.Abstracts;
using NTierApplication.BLL.Services.Concretes;
using NTierApplication.Core.Infrastructure.Messaging.Abstracts;
using NTierApplication.Core.Infrastructure.Messaging.SystemNetMail;
using NTierApplication.DAL.ORM.EntityFramework.Context;
using NTierApplication.Repository.Repositories.Abstracts;
using NTierApplication.Repository.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApplication.UI.WindowsForms.DependecyResolver
{
    public static class NinjectDependencyContainer
    {
        public static int ProjectContext { get; private set; }

        public static IKernel RegisterDependency(IKernel kernel)
        {
            kernel.Bind<DbContext>().To<ProjectContext>();


            kernel.Bind<IProductService>().To<ProductService>();
            kernel.Bind<IProductRepository>().To<ProductRepository>();
            kernel.Bind<ICategoryRepository>().To<CategoryRepository>();
            kernel.Bind<ICategoryService>().To<CategoryService>();
            kernel.Bind<IMessaging>().To<SystemNetMailManager>();

            return kernel;
        }
    }
}
