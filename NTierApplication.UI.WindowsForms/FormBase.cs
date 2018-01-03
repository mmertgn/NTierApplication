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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void ürünPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.Show();
            Hide();
        }

        

        private void kategoriPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.Show();
            Hide();
        }
    }
}
