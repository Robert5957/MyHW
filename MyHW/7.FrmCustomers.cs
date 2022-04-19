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
                        this.cbbCountry.Items.Add(sdr["Country"].ToString());
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
                    Random rnd = new Random();
                    while (sdr.Read())
                    {
                        ListViewItem lvi = this.lsVCustomers.Items.Add(sdr[0].ToString());
                     
                        lvi.ImageIndex = rnd.Next(0, this.ImageList1.Images.Count);

                        if (lvi.Index % 2 == 0)
                        {
                            lvi.BackColor = Color.LightBlue;
                        }
                        else
                        {
                            lvi.BackColor = Color.LightGreen;
                        }
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
            using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString)) {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select CompanyName from Customers where Country='USA';select CompanyName from Customers where Country='UK'";
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                lsVCustomers.Items.Clear();
                int n = 0;
                int k = 0;
                while (dr.Read())
                {
                    ListViewItem lvi = this.lsVCustomers.Items.Add(dr["CompanyName"].ToString());
                    if (this.lsVCustomers.Groups["USA"] == null)
                    {
                        ListViewGroup gUSA = this.lsVCustomers.Groups.Add("USA", "USA");
                        gUSA.Tag = 0;
                        lvi.Group = gUSA;
                    }
                    else
                    {
                        ListViewGroup gUSA = this.lsVCustomers.Groups["USA"];
                        lvi.Group = gUSA;
                    }
                    this.lsVCustomers.Groups["USA"].Tag = 0;
                    n = lsVCustomers.Items.Count;
                    this.lsVCustomers.Groups["USA"].Header = "USA" +"("+n+")"; 
                }
                dr.NextResult();
               
                while (dr.Read())
                {
                       ListViewItem lvi = this.lsVCustomers.Items.Add(dr["CompanyName"].ToString());
                    if (this.lsVCustomers.Groups["UK"] == null)
                    {
                        ListViewGroup group = this.lsVCustomers.Groups.Add("UK", "UK");
                        group.Tag = 0;
                        lvi.Group = group;
                    }
                    else
                    {
                        ListViewGroup group= this.lsVCustomers.Groups["UK"];
                        lvi.Group = group;
                    }
                    this.lsVCustomers.Groups["UK"].Tag = 1;
                     k= lsVCustomers.Items.Count;
                    this.lsVCustomers.Groups["UK"].Header = "UK" + "(" +(k- n )+ ")";
                }

            }
      
            
            }
        }
    }
