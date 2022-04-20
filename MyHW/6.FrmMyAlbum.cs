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
            loadPicTravelled();
            //for crud picture
            this.pictureBoxAlbum.AllowDrop = true;
            this.pictureBoxAlbum.DragEnter += PictureBoxAlbum_DragEnter;
            this.pictureBoxAlbum.DragDrop += PictureBoxAlbum_DragDrop;
            //picture show in flow panel
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.DragDrop += FlowLayoutPanel2_DragDrop;
            this.flowLayoutPanel2.DragEnter += FlowLayoutPanel2_DragEnter;
        }
        string sqlconn = Settings.Default.MyLogon;
         Form fs = new Form();
        private void loadPicTravelled()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlconn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"Select distinct cityName from pictureTour as p join city on p.cityID=city.cityID order by cityName ";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    comboBoxCitySearch.Items.Clear();
                    while (dr.Read())
                    {
                        comboBoxCitySearch.Items.Add(dr["cityName"]);
                    }
                    comboBoxCitySearch.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//游歷的城市
        private void FlowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void FlowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < files.Length; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(files[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 100;
                pic.Height = 50;
                this.flowLayoutPanel2.Controls.Add(pic);
                pic.Click += Pic_Click1;
            }
        }//多筆相片拖拉
        private void PictureBoxAlbum_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.pictureBoxAlbum.Image = Image.FromFile(files[0]);
        }//單筆相片拖拉
        private void PictureBoxAlbum_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void loadTravelArea()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlconn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select distinct  countryName from country order by countryName;" +
                       $"select  cityName from city  join country  on city.countryID=country.countryID  where countryName= '{comboBoxCountry.SelectedItem}' ";
                    cmd.Connection = conn;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBoxCountry.Items.Add(dr[0].ToString());
                    }
                    comboBoxCountry.SelectedItem = "臺灣，中華民國";
                    dr.NextResult();
                    while (dr.Read())
                    {
                        comboBoxCity.Items.Add(dr[0].ToString());
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }//國家地區產生
        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlconn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"Select cityName, cityID from city join country on city.countryID=country.countryID where countryName='{comboBoxCountry.SelectedItem}'";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    comboBoxCity.Items.Clear();
                    while (dr.Read())
                    {
                        comboBoxCity.Items.Add(dr["cityName"]);
                        lblCityID.Text = dr["cityID"].ToString();
                    }
                    comboBoxCity.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyLogon))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"select cityID from city   where cityName= '{comboBoxCity.SelectedItem}' ";
                    cmd.Connection = conn;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lblCityID.Text = dr["cityID"].ToString();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        void myButton()
        {
            SqlConnection conn = null;
            panel1.Controls.Clear();
            try
            {
                conn = new SqlConnection(sqlconn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select distinct cityName from pictureTour  as p join city as c on p.cityID = c.cityID", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Button b = new Button();
                    b.Text = dt.Rows[i][0].ToString();
                    b.BackColor = Color.Blue;
                    b.ForeColor = Color.White;
                    b.Left = 17;
                    b.Top = 30 * i;
                    //b.Tag = i;//ID
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
        }//相簿城市按鈕產生
        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlconn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"Select Picture from pictureTour  as p join City as c on p.cityID= c.cityID where cityName = '{b.Text}'";
                    cmd.Connection = conn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    this.flowLayoutPanel1.Controls.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PictureBox pic = new PictureBox();
                        byte[] bytes = (byte[])dt.Rows[i]["Picture"];
                        MemoryStream ms = new MemoryStream(bytes);
                        pic.Image = Image.FromStream(ms);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 100;
                        pic.Height = 100;
                        this.flowLayoutPanel1.Controls.Add(pic);
                        pic.Click += Pic_Click1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//城市相簿產生
        private void txtInpuCity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlconn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"select cityID from city   where cityName= '{txtInpuCity.Text}' ";
                    cmd.Connection = conn;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lblCityID.Text = dr["cityID"].ToString();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlconn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"Select * from pictureTour as p join  city on p.cityID=city.cityID where cityName='{comboBoxCitySearch.SelectedItem}'";
                    cmd.Connection = conn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    //this.flowLayoutPanel2.Controls.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PictureBox pic = new PictureBox();
                        byte[] bytes = (byte[])dt.Rows[i]["Picture"];
                        MemoryStream ms = new MemoryStream(bytes);
                        pic.Image = Image.FromStream(ms);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 100;
                        pic.Height = 100;
                        pic.Name = dt.Rows[i]["pictureID"].ToString();
                        this.flowLayoutPanel2.Controls.Add(pic);
                        pic.Click += Pic_Click;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//查詢
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //todo...
            //int tagp = 0;
            //foreach (PictureBox pb in flowLayoutPanel2.Controls.OfType<PictureBox>())
            //{
            //    //PictureBox pb = (PictureBox)flowLayoutPanel2.Controls.OfType(PictureBox);
            //    tagp =(int)pb.Tag;

            //}
            //lblCityID.Text = tagp.ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.RemoveAt(indexPB);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select picture files";
                ofd.InitialDirectory = ".\\";
                ofd.Filter = "image files(*.gif;*.jpeg;*.jpg;*.bmp)|*.gif;*.jpeg;*.jpg;*.bmp";
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    pictureBoxAlbum.Image = Image.FromFile(ofd.FileName);
                }
            }
        }//單筆相片上傳
        private void btnFolder_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image|*.jpeg;*.jpg;*.bmp",
                ValidateNames = true,
                Multiselect = true
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.flowLayoutPanel2.Controls.Clear();
                    foreach (string k in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(k);
                        string items = fi.FullName;
                        folderGetfile(items);
                    }

                }
            }
        }//多筆相片上傳
        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            folderBrowserDialog1.ShowDialog();
            string folderName = folderBrowserDialog1.SelectedPath;
            foreach (string items in Directory.GetFiles(folderName))
            {
                folderGetfile(items);
            }
        }//整批相片上傳
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(sqlconn);
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = "addPicture";
                cmd1.Connection = conn;
                cmd1.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd1.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                cmd1.Parameters.AddWithValue("@cityID", lblCityID.Text.Trim());
                cmd1.Parameters.AddWithValue("@remark", txtRemarks.Text.Trim());
                MemoryStream ms = new MemoryStream();
                byte[] pict = new byte[ms.Length];
                pictureBoxAlbum.Image.Save(ms, ImageFormat.Jpeg);
                pict = ms.GetBuffer();
                cmd1.Parameters.AddWithValue("@picture", pict);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("相片增加成功!");
                myButton();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//單筆資料儲存
        private void btnSaveAll_Click(object sender, EventArgs e)//save all from FlowPanel 2
        {
            using (SqlConnection conn = new SqlConnection(sqlconn))
            {
               conn.Open();
                foreach (PictureBox pb in flowLayoutPanel2.Controls)//get the pictureBox control from flowlayoutpanel
                {     SqlCommand cmd = new SqlCommand(); 
                       
                   cmd.Connection = conn;  cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@cityID", lblCityID.Text.Trim());
                    cmd.Parameters.AddWithValue("@remark", txtRemarks.Text.Trim());
                  cmd.CommandText = "addPicture";
                    cmd.CommandType = CommandType.StoredProcedure;
                     MemoryStream ms = new MemoryStream();
                    byte[] pict = new byte[ms.Length];
                    pb.Image.Save(ms, ImageFormat.Jpeg);
                    pict = ms.GetBuffer();
                    cmd.Parameters.AddWithValue("@picture", pict);
                    cmd.ExecuteNonQuery();
                }  
                MessageBox.Show("Save all  photos!");
            }
               myButton(); 
        }//全部相片儲存
        int indexPB = 0;
       private void Pic_Click(object sender, EventArgs e)
        {
            pictureBoxAlbum.Image = ((PictureBox)sender).Image;
            pictureBoxAlbum.BackgroundImageLayout = ImageLayout.Stretch;
                var pictureBox = (PictureBox)sender;
                indexPB = flowLayoutPanel2.Controls.GetChildIndex(pictureBox);
        }//相簿單筆預覽
        private void Pic_Click1(object sender, EventArgs e)
        {
            fs.BackgroundImage = ((PictureBox)sender).Image;
            fs.BackgroundImageLayout = ImageLayout.Stretch;
            fs.Show();
            fs.BringToFront();
        }//上傳相簿單筆預覽
        void folderGetfile(string items)
        {
            PictureBox pic = new PictureBox();
            pic.Width = 100;
            pic.Height = 100;
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.Image = Image.FromFile(items);
            flowLayoutPanel2.Controls.Add(pic);
            pic.Click += Pic_Click;
        }//FolderGetfiles to show in flowpanel//多筆相片產生預覽
        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.RemoveAt(indexPB);
        }
    }
}

