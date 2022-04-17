using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsToolControls
{
    public partial class FrmListViewCRUD : Form
    {
        string radioText = "";
        public FrmListViewCRUD()
        {
            InitializeComponent();
            //LV property
            this.listView.View = View.Details;
            this.listView.AllowColumnReorder = true;
            this.listView.FullRowSelect = true;
            //construct columns;
            listView.Columns.Add("Name", 100);
            listView.Columns.Add("Age", 100);
            listView.Columns.Add("Gender",100);
            listView.Columns.Add("Country", 100);

        }
        private void add(string name, string age, string radioText,string country) {
            //row
            string[] row = { name, age, radioText,country };
            ListViewItem item = new ListViewItem(row);
            listView.Items.Add(item);
        
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add(txtName.Text, txtAge.Text, radioText, txtCountry.Text);
            clearText();
        }
     
        private void btnClear_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            clearText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 1)
            {
                listView.SelectedItems[0].SubItems[0].Text = txtName.Text;
                listView.SelectedItems[0].SubItems[1].Text = txtAge.Text;
                listView.SelectedItems[0].SubItems[2].Text = radioText;
                listView.SelectedItems[0].SubItems[3].Text = txtAge.Text;
                clearText();
            }
            else { MessageBox.Show("ListView is empty!"); }
        }
        void clearText() {
            txtName.Text = "";
            txtAge.Text = "";
            txtCountry.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure??", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                listView.Items.RemoveAt(listView.SelectedIndices[0]);
                clearText();
            
            }
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
           txtName.Text =listView.SelectedItems[0].SubItems[0].Text ;
           txtAge.Text= listView.SelectedItems[0].SubItems[1].Text  ;
           txtCountry.Text=  listView.SelectedItems[0].SubItems[2].Text;
        }

        private void radioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radioBtnFemale.Checked)
            {
                radioText = radioBtnFemale.Text;
            }
            else { radioText = radiobtnMale.Text; }
        }
    }
}
