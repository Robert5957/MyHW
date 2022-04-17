using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class Frm_DataSET_結構 : Form
    {
        public Frm_DataSET_結構()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.dgvCategory.DataSource = this.nwDataSet1.Categories;
            this.dgvCustomers.DataSource = this.nwDataSet1.Customers;
            this.dgvProducts.DataSource = this.nwDataSet1.Products;
            this.lbDataSet.Items.Clear();
            for (int i = 0; i < nwDataSet1.Tables.Count; i++)
            {
                DataTable dt = this.nwDataSet1.Tables[i];
                this.lbDataSet.Items.Add("Table:" + dt.TableName);
                string s = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (j == 0) { s += $"{dt.Columns[j].ColumnName,-15}"; }
                   else if (j==4) { s += $"{dt.Columns[j].ColumnName,-60}"; } else { s += $"{dt.Columns[j].ColumnName,-32}"; }
                 
                }
                this.lbDataSet.Items.Add(s);
                for (int k = 0; k < dt.Rows.Count; k++)
                {
                    string str = "";
                    for (int m = 0; m < dt.Columns.Count; m++)
                    {
                        if (m == 0)
                        {
                            str += $"{dt.Rows[k][m].ToString(),-15}";
                        }
                        else if (m == 4)
                        {
                            str += $"{dt.Rows[k][m].ToString(),-60}";
                        }
                        else { str += $"{dt.Rows[k][m].ToString(),-32}"; }


                }
                    this.lbDataSet.Items.Add(str);
               }
                this.lbDataSet.Items.Add("================================================================================================================================================================================================");
            }
                    }
    }
}
