using Ninject;
using NTierApplication.BLL.Services.Abstracts;
using NTierApplication.Entity.Entities;
using NTierApplication.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierApplication.UI.WindowsForms
{
    public partial class CategoryForm : FormBase
    {

        private readonly ICategoryService _categoryService;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IProductRepository _productRepo;

        public CategoryForm()
        {
            var kernel = DependecyResolver.NinjectDependencyContainer.RegisterDependency(new StandardKernel());
            _categoryService = kernel.Get<ICategoryService>();
            _categoryRepo = kernel.Get<ICategoryRepository>();
            _productRepo = kernel.Get<IProductRepository>();


            InitializeComponent();
        }

        private void LoadCategories()
        {
            var model = _categoryRepo.List();

            model.ForEach(item =>
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Name;
                li.SubItems.Add(_productRepo.GetProductsByCategoryId(item.Id).Count().ToString());
                li.Tag = item;
                listView1.Items.Add(li);
            });
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var model = new Category
            {
                Name = txtCategoryName.Text
            };

            var result = _categoryService.Create(model);

            lblResult.Text = result.IsValid ? result.Message : string.Join("\n", result.Errors);

            listView1.Items.Clear();
            LoadCategories();
        }
    }
}
