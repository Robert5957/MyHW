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
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Select  Country  ,count(City) from Customers group by Country";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        TreeNode tn = this.treeView1.Nodes.Add(ds.Tables[0].Rows[i][0].ToString() + "(" + ds.Tables[0].Rows[i][1].ToString() + ")");
                        cmd.CommandText = $"select distinct City from Customers where Country='{ds.Tables[0].Rows[i][0]}'";
                        SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, conn);
                        DataSet ds1 = new DataSet();
                        sda.Fill(ds1);
                        for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
                        {
                            tn.Nodes.Add(ds1.Tables[0].Rows[j][0].ToString());
                        }
                    }
                    cmd.CommandText = "select * from Customers";
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt = dr.GetSchemaTable();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        this.listView1.Columns.Add(dt.Rows[i][0].ToString());
                    }
                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
             }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

      private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tn = new TreeNode();
            string str = treeView1.SelectedNode.Text;
            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {//get the countryname by delete the invalid string
                if (str.Substring(i, 1) == "(")
                {
                    str1 = str.Substring(0, i);
                    break;
                }
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"Select * from dbo.Customers where Country = '{str1}'  or City='{str}'"; 
                    cmd.Connection = conn;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    this.listView1.Items.Clear();
                   while (sdr.Read())
                    {
                        ListViewItem lvi = this.listView1.Items.Add(sdr[0].ToString());
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
    }
}