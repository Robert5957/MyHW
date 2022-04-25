using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                    SqlDataReader dr = cmd.ExecuteReader();
                    //cbbCountry.Items.Clear();
                    while (dr.Read())
                    {
                        this.cbbCountry.Items.Add(dr["Country"].ToString());
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
                    SqlDataReader dr= cmd.ExecuteReader();
                    DataTable dt = dr.GetSchemaTable();//show the columns-name by row
                    
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
                    SqlDataReader dr = cmd.ExecuteReader();
                    this.lsVCustomers.Items.Clear();
                    Random rnd = new Random();
                    while (dr.Read()) {      readformat(dr);}
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
            using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Customers where Country='USA';select * from Customers where Country='UK';select *from Customers where Country<>'USA' or Country<>'UK'";
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    string key = "USA", key1 = "UK", key2 = "Other";
                    int tag = 0, tag1 = 1, tag2 = 2;
                    lsVCustomers.Items.Clear();
                    groupReader(dr, key, tag);
                    dr.NextResult();
                    groupReader(dr, key1, tag1);
                    dr.NextResult();
                    groupReader(dr, key2, 2);
                }
            }
        }
        void groupReader(SqlDataReader dr,string key, int tag)
            {
                //dr.NextResult();
                int s = 0;
            Random rnd = new Random();
                while (dr.Read())
                {
                    s++;
                ListViewItem lvi = this.lsVCustomers.Items.Add(dr[0].ToString());

                lvi.ImageIndex = rnd.Next(0, this.ImageList1.Images.Count);
                if (lvi.Index % 2 == 0)
                {
                    lvi.BackColor = Color.LightBlue;
                }
                else
                {
                    lvi.BackColor = Color.LightGreen;
                }
                for (int i = 1; i < dr.FieldCount; i++)
                {
                    if (dr.IsDBNull(i))
                    {
                        lvi.SubItems.Add("空值");
                    }
                    else
                    {
                        lvi.SubItems.Add(dr[i].ToString());
                    }
                }
                if (this.lsVCustomers.Groups[key] == null)
                    {
                        ListViewGroup group = this.lsVCustomers.Groups.Add(key, key);
                        group.Tag = tag;
                        lvi.Group = group;
                    }
                    else
                    {
                        ListViewGroup group = this.lsVCustomers.Groups[key];
                        lvi.Group = group;
                    }
                    this.lsVCustomers.Groups[key].Tag =tag;
                    //s = lsVCustomers.Items.Count;
                    this.lsVCustomers.Groups[key].Header =key + "(" +s+ ")";
                }
            }
        void readformat(SqlDataReader dr) {
            Random rnd = new Random();
            Thread.Sleep(2);
            //while (dr.Read())
            //        {
                        ListViewItem lvi = this.lsVCustomers.Items.Add(dr[0].ToString());
                     
                        lvi.ImageIndex = rnd.Next(0, this.ImageList1.Images.Count);
                        if (lvi.Index % 2 == 0)
                        {
                            lvi.BackColor = Color.LightBlue;
                        }
                        else
                        {
                            lvi.BackColor = Color.LightGreen;
                        }
                        for (int i = 1; i < dr.FieldCount; i++)
                        {
                            if (dr.IsDBNull(i))
                            {
                                lvi.SubItems.Add("空值");
                            }
                            else
                            {
                                lvi.SubItems.Add(dr[i].ToString());
                            }
                        }
                    //}
        }
        }
        }
    
