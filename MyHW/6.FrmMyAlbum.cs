using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            loadTravelArea();
            int cityIdD = 0;
        }

        private void loadTravelArea()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyLogon))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select distinct  countryName from country order by countryName";
                    cmd.Connection = conn;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBoxCountry.Items.Add(dr[0].ToString());
                    }
                    comboBoxCountry.SelectedItem = "臺灣，中華民國";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            //-------------------------------------combox for city
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyLogon))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"select  cityName from city  join country  on city.countryID=country.countryID  where countryName= '{comboBoxCountry.SelectedItem}' ";
                    cmd.Connection = conn;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBoxCity.Items.Add(dr[0].ToString());
                
                    }
                    comboBoxCity.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void  myButton()
        {
                       SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(Settings.Default.MyLogon);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from pictureTour", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Button b = new Button();
                    b.Text = dt.Rows[i][1].ToString();
                    b.Left = 5;
                    b.Top = 30 * i;
                    b.Tag = i;//ID
                    b.Click += B_Click;
                    this.panel1.Controls.Add(b);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            string sqlCmd = $"Select Picture from album_Picture  as p join album_City as c on p.cityID= c.cityID where cityName = '{b.Text}'";
          
            SqlConnection conn = null;
            try
            {
              
          
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void btnPictureCRUD_Click(object sender, EventArgs e)
        {
          
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
             using (OpenFileDialog ofd = new OpenFileDialog())
            { ofd.Title = "Select picture files";
              ofd.InitialDirectory = ".\\";
              ofd.Filter = "image files(*.gif;*.jpeg;*.jpg;*.bmp)|*.gif;*.jpeg;*.jpg;*.bmp";
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    pictureBoxAlbum.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           
                try
                {
                    SqlConnection conn = new SqlConnection(Settings.Default.MyLogon);
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.CommandText = "addPicture";
                        cmd1.Connection = conn;
                        cmd1.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        cmd1.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                        cmd1.Parameters.AddWithValue("@cityID", comboBoxCity.SelectedIndex);
                        cmd1.Parameters.AddWithValue("@remark", txtRemarks.Text.Trim());
                        MemoryStream ms = new MemoryStream();                
                        pictureBoxAlbum.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] pict = new byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(pict, 0, pict.Length);
                        cmd1.Parameters.AddWithValue("@picture", pict);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("相片增加成功!");
                    
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

      
    }
}
