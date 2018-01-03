using Ninject;
using NTierApplication.BLL.Services.Abstracts;
using NTierApplication.Entity.Entities;
using NTierApplication.Repository.Repositories.Abstracts;
using NTierApplication.UI.WindowsForms.DependecyResolver;
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
    public partial class ProductForm : FormBase
    {
        private readonly IProductService _service;
        private readonly IProductRepository _repo;
        private readonly ICategoryRepository _categoryRepo;

        public ProductForm()
        {
            var container = NinjectDependencyContainer.RegisterDependency(new StandardKernel());
            _service = container.Get<IProductService>();
            _repo = container.Get<IProductRepository>();
            _categoryRepo = container.Get<ICategoryRepository>();

            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            #region ContextMenu

            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add("Güncelle", new EventHandler(Product_Update));
            menu.MenuItems.Add("Sil", new EventHandler(Product_Delete));

            lstProducts.ContextMenu = menu;


            #endregion

            #region ListView

            GetProducts();
            
            #endregion

            #region CategoryComboBox

            cmbCategory.DataSource = _categoryRepo.List();
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";

            #endregion
        }

        private void Product_Delete(object sender, EventArgs e)
        {
            Product selected = lstProducts.FocusedItem.Tag as Product;

            _repo.Delete(selected.Id);
            lstProducts.Items.Clear();
            GetProducts();

        }

        private void Product_Update(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void GetProducts()
        {
            var model = _repo.List();

            model.ForEach(item =>
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Name;
                li.SubItems.Add(item.Price.ToString());
                li.SubItems.Add(item.Stock.ToString());
                li.SubItems.Add(_categoryRepo.GetById((int)item.CategoryId).Name);
                li.Tag = item;

                lstProducts.Items.Add(li);
            });

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product model = new Product
            {
                Name = txtProductName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Stock = short.Parse(txtStock.Text),
                CategoryId = (cmbCategory.SelectedItem as Category).Id
            };

            var result = _service.ProductSave(model);

            lblResult.Text = result.IsValid ? result.Message : string.Join("\n",result.Errors);

            lstProducts.Items.Clear();
            GetProducts();

        }
    }
}
