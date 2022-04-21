using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmPhotoShow : Form
    {
        public FrmPhotoShow()
        {
            InitializeComponent();
        }

        private void FrmPhotoShow_Load(object sender, EventArgs e)
        {

        }

        private void FrmPhotoShow_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
