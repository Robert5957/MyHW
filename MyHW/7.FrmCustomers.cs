using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
           InitializeComponent();
            //set listView property
            this.lsVCustomers.View = View.Details;
            this.lsVCustomers.AllowColumnReorder = true;
            LoadCbBCountry();
            CreateListViewColumns();
        }
        private void LoadCbBCountry()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Select distinct Country from dbo.Customers", conn);
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    //cbbCountry.Items.Clear();
                    while (sdr.Read())
                    {
                        this.cbbCountry.Items.Add(sdr[0].ToString());
                    }
                    this.cbbCountry.Items.Add("All Country");
                    this.cbbCountry.SelectedItem = "All Country";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void CreateListViewColumns()
        {     try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Select * from Customers", conn);
                    conn.Open();
                    SqlDataReader sdr= cmd.ExecuteReader();
                    DataTable dt = sdr.GetSchemaTable();//show the columns-name by row
                  for(int i=0;i<dt.Rows.Count;i++)
                     {
                        this.lsVCustomers.Columns.Add(dt.Rows[i][0].ToString());
                    }
                    this.lsVCustomers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = cbbCountry.Text;
              try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    if (str == "All Country") { cmd.CommandText = "Select * from dbo.Customers order by country"; }
                    else { cmd.CommandText = $"Select * from dbo.Customers where country='{cbbCountry.SelectedItem} ' "; }
                    cmd.Connection = conn;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    this.lsVCustomers.Items.Clear();
                    while (sdr.Read())
                    {
                        ListViewItem lvi = this.lsVCustomers.Items.Add(sdr[0].ToString());
                        for (int i = 1; i < sdr.FieldCount; i++)
                        {
                            if (sdr.IsDBNull(i))
                            {
                                lvi.SubItems.Add("空值");
                            }
                            else
                            {
                                lvi.SubItems.Add(sdr[i].ToString());
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void detailsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lsVCustomers.View = View.Details;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lsVCustomers.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lsVCustomers.View = View.SmallIcon;
        }

        private void orderByToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupByToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customersIDASCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsVCustomers.Sorting = System.Windows.Forms.SortOrder.Ascending;
                 }

        private void customersIDDESCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsVCustomers.Sorting = System.Windows.Forms.SortOrder.Descending;
                 }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}