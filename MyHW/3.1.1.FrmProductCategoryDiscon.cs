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
    public partial class FrmProductCategoryDiscon : Form
    {
        public FrmProductCategoryDiscon()
        {
            InitializeComponent();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from categories ", conn);
                SqlDataAdapter adapterP = new SqlDataAdapter("select * from products where categoryid=3",conn);
                DataSet ds1 = new DataSet();
                adapterP.Fill(ds1);
                DataRow[] custRows = ds1.Tables[0].Select("categoryID =3", "ProductName");
                this.lbDisconnected.Items.Clear();
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    this.lbDisconnected.Items.Add(ds1.Tables[0].Rows[i]["ProductName"]);
                };
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.cbDisconnected.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    this.cbDisconnected.Items.Add(ds.Tables[0].Rows[i]["CategoryName"]);
                };
            }
            catch (Exception ex) { }
            finally
            {
                if (conn != null)
                { conn.Close(); }
            }
                    }

        private void cbDisconnected_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comB = (ComboBox)sender;
            string selectItem = (string)comB.SelectedItem;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"Select ProductName from Products as p join Categories as c on p.CategoryID=c.CategoryID where CategoryName='{selectItem}'", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.lbDisconnected.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    this.lbDisconnected.Items.Add(ds.Tables[0].Rows[i]["ProductName"]);
                };
            }
            catch (Exception ex) { }
            finally
            {
                if (conn != null)
                { conn.Close(); }
            }
        }
            }
}
