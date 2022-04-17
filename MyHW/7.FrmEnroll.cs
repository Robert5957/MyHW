using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyHW.Properties;
using System.IO;
using System.Drawing.Imaging;

namespace MyHomeWork
{
    public partial class FrmEnroll : Form
    {
        public FrmEnroll()
        {
            InitializeComponent();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPWD.Text == "")//check the mandatory field;
            {
                MessageBox.Show("Fill the mandatory field");
            }
            else if (txtPWD.Text != txtPWDconform.Text)
            {
                MessageBox.Show("Password don't match ");//check the password and confirmpassword are the same;
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(Settings.Default.MyLogon);
                    SqlCommand cmd = new SqlCommand("Select accountName from accountLogon where accountName=@userName", conn);
                   conn.Open();
                    cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
                    SqlDataReader dReader = cmd.ExecuteReader();
                   if (dReader.HasRows)//check the username is unique
                    {
                        MessageBox.Show("註冊的帳號已被使用");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.CommandText = "addUser";
                        cmd1.Connection = conn;
                        cmd1.CommandType = CommandType.StoredProcedure;
                          conn.Open();
                        cmd1.Parameters.AddWithValue("@accountName", txtUserName.Text);
                        cmd1.Parameters.AddWithValue("@accountPassword", txtPWD.Text.Trim());
                        cmd1.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim()) ;
                        cmd1.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
                        cmd1.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd1.Parameters.AddWithValue("@contactPhone", txtPhone.Text.Trim());
                        cmd1.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        MemoryStream ms = new MemoryStream();                 //
                        PictureBoxEnroll.Image.Save(ms,ImageFormat.Jpeg);
                        byte[] pict = new byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(pict, 0, pict.Length);
                        cmd1.Parameters.AddWithValue("@picture", pict);
                        cmd1.ExecuteNonQuery(); 
                        MessageBox.Show("註冊成功!");
                                      }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
          private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream imageStream = null;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select picture files";
                ofd.InitialDirectory = ".\\";
                ofd.Filter = "image files(*.gif;*.jpeg;*.jpg;*.bmp)|*.gif;*.jpeg;*.jpg;*.bmp";
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        if ((imageStream = ofd.OpenFile()) != null)
                        {
                            if (imageStream.Length > 5120000)
                            { MessageBox.Show("File size limit exceeded"); }
                            else
                            {
                                PictureBoxEnroll.Image = Image.FromFile(ofd.FileName);
                            }
                        }
                        //PictureBoxLogo.Image = Image.FromFile(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

    }
}
