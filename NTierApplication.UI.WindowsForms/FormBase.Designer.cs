namespace NTierApplication.UI.WindowsForms
{
    partial class FormBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.urunİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunİşlemleriToolStripMenuItem,
            this.kategoriİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(431, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // urunİşlemleriToolStripMenuItem
            // 
            this.urunİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünPaneliToolStripMenuItem});
            this.urunİşlemleriToolStripMenuItem.Name = "urunİşlemleriToolStripMenuItem";
            this.urunİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.urunİşlemleriToolStripMenuItem.Text = "Urun İşlemleri";
            // 
            // ürünPaneliToolStripMenuItem
            // 
            this.ürünPaneliToolStripMenuItem.Name = "ürünPaneliToolStripMenuItem";
            this.ürünPaneliToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ürünPaneliToolStripMenuItem.Text = "Ürün Paneli";
            this.ürünPaneliToolStripMenuItem.Click += new System.EventHandler(this.ürünPaneliToolStripMenuItem_Click);
            // 
            // kategoriİşlemleriToolStripMenuItem
            // 
            this.kategoriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriPaneliToolStripMenuItem});
            this.kategoriİşlemleriToolStripMenuItem.Name = "kategoriİşlemleriToolStripMenuItem";
            this.kategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.kategoriİşlemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            // 
            // kategoriPaneliToolStripMenuItem
            // 
            this.kategoriPaneliToolStripMenuItem.Name = "kategoriPaneliToolStripMenuItem";
            this.kategoriPaneliToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.kategoriPaneliToolStripMenuItem.Text = "Kategori Paneli";
            this.kategoriPaneliToolStripMenuItem.Click += new System.EventHandler(this.kategoriPaneliToolStripMenuItem_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 404);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem urunİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriPaneliToolStripMenuItem;
    }
}