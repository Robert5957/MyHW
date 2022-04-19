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
    public partial class Quizz : Form
    {
        public Quizz()
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
                        TreeNode tn = this.treeView1.Nodes.Add(ds.Tables[0].Rows[i][0].ToString() + "(" + ds.Tables[0].Rows[i][1].ToString());
                        cmd.CommandText = $"select distinct City from Customers where Country='{ds.Tables[0].Rows[i][0]}'";
                        SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, conn);
                        DataSet ds1 = new DataSet();
                        sda.Fill(ds1);
                        for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
                        {
                            tn.Nodes.Add(ds1.Tables[0].Rows[j][0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}