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
    public partial class FrmProductCategory : Form
    {
        public FrmProductCategory()
        {
            InitializeComponent();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Categories", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                this.comboBox.Items.Clear();
                while (dataReader.Read())
                {
                    string s = $"{dataReader["CategoryName"]} ";
                    this.comboBox.Items.Add(s);
                };
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              ComboBox comboBox = (ComboBox)sender;
            string selectedCategory = (string)comboBox.SelectedItem;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand($"Select ProductName from Products as p join Categories as c on p.CategoryID=c.CategoryID where CategoryName='{selectedCategory}'", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                this.listBox.Items.Clear();
                while (dataReader.Read())
                {
                    string s = $"{dataReader["ProductName"]} ";
                    this.listBox.Items.Add(s);
                };
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
