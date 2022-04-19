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
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHomeWork MC = new FrmHomeWork();
            splitContainer2.Panel2.Controls.Clear();
            IsMdiContainer = true;
            MC.MdiParent = this;
            MC.Parent = splitContainer2.Panel2;
            MC.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(MC);
            MC.BringToFront();
            MC.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMyAlbum MC = new FrmMyAlbum();
            splitContainer2.Panel2.Controls.Clear();
            IsMdiContainer = true;
            MC.MdiParent = this;
            MC.Parent = splitContainer2.Panel2;
            MC.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(MC);
            MC.BringToFront();
            MC.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAdventureWorks MC = new FrmAdventureWorks();
            splitContainer2.Panel2.Controls.Clear();
            IsMdiContainer = true;
            MC.MdiParent = this;
            MC.Parent = splitContainer2.Panel2;
            MC.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(MC);
            MC.BringToFront();
            MC.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Quizz MC = new Quizz();
            splitContainer2.Panel2.Controls.Clear();
            IsMdiContainer = true;
            MC.MdiParent = this;
            MC.Parent = splitContainer2.Panel2;
            MC.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(MC);
            MC.BringToFront();
            MC.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmLogon MC = new FrmLogon();
            splitContainer2.Panel2.Controls.Clear();
            IsMdiContainer = true;
            MC.MdiParent = this;
            MC.Parent = splitContainer2.Panel2;
            MC.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(MC);
            MC.BringToFront();
            MC.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmCustomers MC = new FrmCustomers();
            splitContainer2.Panel2.Controls.Clear();
            IsMdiContainer = true;
            MC.MdiParent = this;
            MC.Parent = splitContainer2.Panel2;
            MC.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(MC);
            MC.BringToFront();
            MC.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_DataSET_結構 MC = new Frm_DataSET_結構();
            splitContainer2.Panel2.Controls.Clear();
            IsMdiContainer = true;
            MC.MdiParent = this;
            MC.Parent = splitContainer2.Panel2;
            MC.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(MC);
            MC.BringToFront();
            MC.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmProducts MC = new FrmProducts();
            splitContainer2.Panel2.Controls.Clear();
            IsMdiContainer = true;
            MC.MdiParent = this;
            MC.Parent = splitContainer2.Panel2;
            MC.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(MC);
            MC.BringToFront();
            MC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          FrmProductCategory MC = new FrmProductCategory();
            splitContainer2.Panel2.Controls.Clear();
            IsMdiContainer = true;
            MC.MdiParent = this;
            MC.Parent = splitContainer2.Panel2;
            MC.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(MC);
            MC.BringToFront();
            MC.Show();
        }
    }
}