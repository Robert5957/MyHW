using MyHomeWork;
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
using System.IO;
using MyHW.Properties;

namespace MyHW
{
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmEnroll register = new FrmEnroll();
            register.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPWD.Text == "") {
                MessageBox.Show("欄位空白, 無法登入");
            
            } else {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyLogon))
                {
                    conn.Open();
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.CommandText = "Select accountName, accountPassword,picture from accountLogon where accountName=@accountName and accountPassword=@accountPassword ";
                    sqlcmd.Parameters.AddWithValue("@accountName", txtUserName.Text);
                    sqlcmd.Parameters.AddWithValue("@accountPassword", txtPWD.Text);
                    sqlcmd.Connection = conn;
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        byte[] photo = new byte[0];
                        photo = (byte[])ds.Tables[0].Rows[0]["picture"];
                        MemoryStream ms = new MemoryStream(photo);
                        ms.Position = 0;
                        PictureBoxLogo.Image = Image.FromStream(ms);
                        MessageBox.Show("登入成功!");
                    }
                    else { MessageBox.Show("帳號或密碼錯誤!");
                        txtUserName.Text = txtPWD.Text = " ";
                        txtUserName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = txtPWD.Text = "";
            this.Close();
        }
    }
}