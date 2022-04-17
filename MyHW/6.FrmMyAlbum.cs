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
    public partial class FrmMyAlbum : Form
    {
        public FrmMyAlbum()
        {
            InitializeComponent();
            myButton();
        }
        void  myButton()
        {
            //string connString = Settings.Default.MyLocalDb;

            SqlConnection conn = null;
            //try
            //{
            //    conn = new SqlConnection(connString);
            //    conn.Open();
            //   SqlDataAdapter adapter = new SqlDataAdapter("select * from album_city", conn);
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds);
            //    DataTable dt = ds.Tables[0];
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        Button b = new Button();
            //        b.Text = dt.Rows[i][1].ToString();
            //        b.Left = 5;
            //        b.Top = 30 * i;
            //        b.Tag = i;//ID
            //        b.Click += B_Click;
            //        this.panel1.Controls.Add(b);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    if (conn != null)
            //    {
            //        conn.Close();
            //    }
            //}
         }
        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
           
            //string sqlCmd = $"Select Picture from album_Picture  as p join album_City as c on p.cityID= c.cityID where cityName = '{b.Text}'";
            //string connString = Settings.Default.MyLocalDb;
            //SqlConnection conn = null;
            //try
            //{
            //    conn = new SqlConnection(connString);
            //    conn.Open();
            //    SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd, conn);
            //    DataSet ds1 = new DataSet();
            //    adapter.Fill(ds1);
            //    this.bindingSource1.DataSource = ds1.Tables[0];
            //    this.dataGridView1.DataSource = this.bindingSource1;
            //    this.pbAlbum.DataBindings.Add("Image", this.bindingSource1, "Picture", true);
                //DataTable dt = ds1.Tables[0];
                //this.listBox1.Items.Clear();
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    string str = $"{dt.Rows[i][0]}";
                //    this.listBox1.Items.Add(str);

            //    //}
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    if (conn != null)
            //    {
            //        conn.Close();
            //           }
            //}
        }

        private void FrmMyAlbum_Load(object sender, EventArgs e)
        {

        }
    }
}
