using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
       }
        private void btnSearchUnitPrice_Click(object sender, EventArgs e)
        {
            int unitFrom = int.Parse(txtUnitfrom.Text);
            int unitTo = int.Parse(txtUnitpriceto.Text);
            this.productsTableAdapter1.FillSearchUnitprice(this.nwDataSet1.Products, unitFrom, unitTo);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dGVProducts.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.dGVProducts.DataSource = this.nwDataSet1.Products;
        }
              private void btnSearchProdName_Click(object sender, EventArgs e)
        {
            string pName = txtProductName.Text;
            this.productsTableAdapter1.FillPNameFuzzy(this.nwDataSet1.Products, pName);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dGVProducts.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            bindingSource1.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bindingSource1.Position -= 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindingSource1.Position += 1;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bindingSource1.Position = bindingSource1.Count-1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            lblShow.Text= $"{this.bindingSource1.Position+1}/{this.bindingSource1.Count}";
            lblResult.Text = $"結果有{this.bindingSource1.Count}筆";
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
