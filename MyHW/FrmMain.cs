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
using WindowsFormsApp1;

namespace MyHW
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Width = 1300;
            this.Height = 800;
            this.StartPosition = FormStartPosition.CenterScreen;
           
        }
        private void button_Click(object sender, EventArgs e) 
        {
            Button b = (Button)sender;
            b.BackColor = Color.Yellow;
           switch (b.TabIndex)
            {
                case 0:
                    FrmHomeWork MC = new FrmHomeWork();
                    formChange(MC);
                    break;
                case 1:
                    FrmProductCategory MC1 = new FrmProductCategory();
                    formChange(MC1);
                    break;
                case 2:
                    FrmProducts MC2 = new FrmProducts();
                    formChange(MC2);
                    break;
                case 3:
                    Frm_DataSET_結構 MC3 = new Frm_DataSET_結構();
                    formChange(MC3);
                    break;
                case 4:
                    FrmAdventureWorks MC4 = new FrmAdventureWorks();
                    formChange(MC4);
                    break;
                case 5:
                    FrmMyAlbum MC5 = new FrmMyAlbum();
                    formChange(MC5);
                    break;
                case 6:
                    FrmCustomers MC6 = new FrmCustomers();
                    formChange(MC6);
                    break;
                case 7:
                    FrmLogon MC7 = new FrmLogon();
                    formChange(MC7);
                    break;
                case 8:
                    Quizz MC8 = new Quizz();
                    formChange(MC8);
                    break;
            }
        }
        void formChange(Form MC)
        {
            splitContainer2.Panel2.Controls.Clear();
            IsMdiContainer = true;
            MC.MdiParent = this;
            MC.Parent = splitContainer2.Panel2;
            MC.TopLevel = false;//default true;
            this.splitContainer2.Panel2.Controls.Add(MC);
            MC.BringToFront();
            MC.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = false;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = true;
        }
    }
}