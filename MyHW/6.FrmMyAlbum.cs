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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
        public partial class FrmMyAlbum : Form
    {
        int indexPB = 0;
        string pbtag = "";
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
            //picture show in flowLayoutPanel
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.DragDrop += FlowLayoutPanel2_DragDrop;
            this.flowLayoutPanel2.DragEnter += FlowLayoutPanel2_DragEnter;
        }
        string sqlconn = Settings.Default.MyLogon;
        FrmPhotoShow fps = new FrmPhotoShow();
        private void loadPicTravelled()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlconn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"Select distinct cityName, count(cityName) from pictureTour as p join city on p.cityID=city.cityID group by cityName ";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    comboBoxCitySearch.Items.Clear();
                    while (dr.Read())
                    {
                        comboBoxCitySearch.Items.Add(dr[0].ToString()+"("+dr[1].ToString()+")");
                    }
                    comboBoxCitySearch.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//游歷的城市及其相片數統計
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
                pic.Width = 250;
                pic.Height =150;
                this.flowLayoutPanel2.Controls.Add(pic);
                pic.Click += Pic_Click;
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
                    comboBoxCountry.SelectedItem = "臺灣";
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
                SqlDataAdapter adapter = new SqlDataAdapter("Select distinct cityName, count(cityName)   from pictureTour  as p   join city as c on p.cityID = c.cityID group by cityName ", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                this.panel1.Controls.Add(btnAutoPlay);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Button b = new Button();
                    b.Text = dt.Rows[i][0].ToString()+"("+dt.Rows[i][1].ToString()+")";
                    b.BackColor = Color.Blue;
                    b.ForeColor = Color.White;
                    b.Width = 123;
                    b.Height = 35;
                    b.BackColor = Color.AliceBlue;
                    b.ForeColor = Color.Black;
                    b.Anchor = AnchorStyles.Left;
                    b.Location= new Point(btnAutoPlay.Left, btnAutoPlay.Top +20+50*i);
                    b.MouseEnter += button_MouseEnter;
                    b.MouseLeave += button_MouseLeave;
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
                    string txtB = "";
                    for (int i = 0; i < b.Text.Length; i++)
                    {
                        if (b.Text.Substring(i, 1) == "(")
                        {
                            txtB = b.Text.Substring(0, i);
                        }
                    }
                    cmd.CommandText = $"Select Picture from pictureTour  as p join City as c on p.cityID= c.cityID where cityName = '{txtB}'";
                    cmd.Connection = conn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    this.flowLayoutPanel1.Controls.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {  
                        PictureBox pic = new PictureBox();
                        pic.MouseEnter += pic_MouseEnter;
                        pic.MouseLeave += pic_MouseLeave;
                        byte[] bytes = (byte[])dt.Rows[i]["Picture"];
                        MemoryStream ms = new MemoryStream(bytes);
                        pic.Image = Image.FromStream(ms);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 250;
                        pic.Height = 150;
                        this.flowLayoutPanel1.Controls.Add(pic);
                        pic.Click += Pic_Click1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//城市相簿產生及其相片數統計
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
            string txtB = "";
            for (int i = 0; i < comboBoxCitySearch.Items.Count; i++)
            {
                if (comboBoxCitySearch.Text.Substring(i, 1) == "(")
                {
                    txtB = comboBoxCitySearch.Text.Substring(0, i);
                }
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlconn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"Select pictureID,picture  from pictureTour as p join  city on p.cityID=city.cityID  where cityName='{txtB}' ";
                    cmd.Connection = conn;
                   SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    //this.flowLayoutPanel2.Controls.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PictureBox pic = new PictureBox();
                        byte[] bytes = (byte[])dt.Rows[i]["picture"];
                        MemoryStream ms = new MemoryStream(bytes);
                        pic.Image = Image.FromStream(ms);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 250;
                        pic.Height = 150;
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
        }//查詢資料庫照片以利管理
        private void btnUpdate_Click(object sender, EventArgs e)
        {
          int updateID=int.Parse(pbtag);
            try
            {
                SqlConnection conn = new SqlConnection(sqlconn);
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = $"update pictureTour set loadDate=@loadDate, remark=@remark where pictureID='{@updateID}'";
                cmd1.Connection = conn;
                //cmd1.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd1.Parameters.AddWithValue("@loadDate", dateTimePicker1.Value);
                //cmd1.Parameters.AddWithValue("@cityID", lblCityID.Text.Trim());
                cmd1.Parameters.AddWithValue("@remark", txtRemarks.Text.Trim());
                 cmd1.ExecuteNonQuery();
                MessageBox.Show("相片資料修改成功!");
                myButton();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//資料庫照片資訊更新
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int updateID = int.Parse(pbtag);
            flowLayoutPanel2.Controls.RemoveAt(indexPB);
            try
            {
                SqlConnection conn = new SqlConnection(sqlconn);
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = $"delete  pictureTour  where pictureID='{@updateID}'";
                cmd1.Connection = conn;
                //cmd1.CommandType = CommandType.StoredProcedure;
                conn.Open();
              //  cmd1.Parameters.AddWithValue("@loadDate", dateTimePicker1.Value);
                //cmd1.Parameters.AddWithValue("@cityID", lblCityID.Text.Trim());
                //cmd1.Parameters.AddWithValue("@remark", txtRemarks.Text.Trim());
                cmd1.ExecuteNonQuery();
                MessageBox.Show("相片資料刪除成功!");
                myButton();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }//資料庫單筆刪除
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
                Filter = "Image|*.jpeg;*.jpg;*.bmp;*.png",
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
            foreach (string items in Directory.GetFiles(folderName, "*.*", SearchOption.AllDirectories)
            .Where(s => s.EndsWith(".jpeg") || s.EndsWith(".jpg")|| s.EndsWith(".bmp") || s.EndsWith(".png")))
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
                cmd1.Parameters.AddWithValue("@loadDate", dateTimePicker1.Value);
                cmd1.Parameters.AddWithValue("@cityID", lblCityID.Text.Trim());
                cmd1.Parameters.AddWithValue("@remark", txtRemarks.Text.Trim());
                MemoryStream ms = new MemoryStream();
                byte[] pict = new byte[ms.Length];
                pictureBoxAlbum.Image.Save(ms, ImageFormat.Jpeg);
                pict = ms.GetBuffer();
                cmd1.Parameters.AddWithValue("@picture", pict);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("回憶滿滿!");
                myButton();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//單筆資料儲存
        private void btnSaveAll_Click(object sender, EventArgs e)//save all from FlowPanel 2
        {
            if (flowLayoutPanel2.Controls.Count !=0)
            {
                using (SqlConnection conn = new SqlConnection(sqlconn))
                {
                    conn.Open();
                    foreach (PictureBox pb in flowLayoutPanel2.Controls)//get the pictureBox control from flowlayoutpanel
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn; 
                        cmd.Parameters.AddWithValue("@loadDate", dateTimePicker1.Value);
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
                    MessageBox.Show("回憶滿滿!");
                }
                myButton();
            }
            else { MessageBox.Show("說走就走!"); }
        }//全部相片儲存
       private void Pic_Click(object sender, EventArgs e)
        {
            pictureBoxAlbum.Image = ((PictureBox)sender).Image;
            pictureBoxAlbum.BackgroundImageLayout = ImageLayout.Stretch;
            var pictureBox = (PictureBox)sender;
            indexPB = flowLayoutPanel2.Controls.GetChildIndex(pictureBox);//get the controls and take a action
            pbtag = (String)pictureBox.Name;
        }//相簿單筆預覽
        private void Pic_Click1(object sender, EventArgs e)
        {
         
            fps.BackgroundImage = ((PictureBox)sender).Image;
            fps.BackgroundImageLayout = ImageLayout.Stretch;
            fps.Show();
            fps.BringToFront();
        }//上傳相簿單筆預覽
        void folderGetfile(string items)
        {
            PictureBox pic = new PictureBox();
            pic.Width = 250;
            pic.Height = 150;
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.MouseEnter += pic_MouseEnter;
            pic.MouseLeave += pic_MouseLeave;
            pic.Image = Image.FromFile(items);
            flowLayoutPanel2.Controls.Add(pic);
            pic.Click += Pic_Click;
        }//FolderGetfiles to show in flowpanel//多筆相片產生預覽
        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.RemoveAt(indexPB);
        }//多筆或整批資料上傳, 按右鍵刪除不要的相片
          private void btnAutoPlay_Click(object sender, EventArgs e)
        {
            fps = new FrmPhotoShow();
            foreach (PictureBox pb in flowLayoutPanel1.Controls)
            {
                PictureBox pbshow = new PictureBox();
                pbshow.BackgroundImageLayout = ImageLayout.Stretch;
                fps.Height = 600;
                fps.Width = 700;
                fps.Controls.Add(pbshow);
                fps.BackgroundImage = pb.Image;
                pbshow.Visible = false;
                fps.BackgroundImageLayout = ImageLayout.Stretch;
                fps.StartPosition = FormStartPosition.CenterParent;
                fps.Show();
                fps.BringToFront();
                Thread.Sleep(1000);
                fps.Controls.Clear();
            }
        }
        private void pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.None;
            pb.Padding = new Padding(0);
        }
        private void pic_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.Fixed3D;
            pb.BackColor = Color.Red;
            pb.Padding = new Padding(4);
        }
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.Red;
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.LightBlue;
        }
    }
    }


