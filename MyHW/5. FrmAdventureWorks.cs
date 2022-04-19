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
namespace MyHomeWork
{
    public partial class FrmAdventureWorks : Form
    {
        public FrmAdventureWorks()
        {
            InitializeComponent();
            this.productPhotoTableAdapter.Fill(this.awDataSet.ProductPhoto);
            this.productPhotoBindingSource.DataSource = this.awDataSet.ProductPhoto;
            this.productPhotoDataGridView.DataSource = this.productPhotoBindingSource;
            this.bindingNavigator1.BindingSource = this.productPhotoBindingSource;
              DataTable dt = awDataSet.ProductPhoto;
            int[] arr = new int[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime t = (DateTime)dt.Rows[i][5];
                arr[i] = t.Year;//substract the Year from datetime
            }
            int[] q = arr.Distinct().ToArray();//delete the same value in arry
            Array.Sort(q);
            dateTimePicker1.Value = new DateTime(q.Min(), 01, 01);//set dateTimePicker intital value
            dateTimePicker2.Value = new DateTime(q.Max(), 12, 31);
            for (int j = 0; j < q.Length; j++)
            {
                if (q[j] != 0) { comboBox1.Items.Add(q[j]); }
            }
            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            int selectYear = int.Parse(cb.SelectedItem.ToString());
           productPhotoTableAdapter.FillByYear(awDataSet.ProductPhoto, selectYear);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            this.productPhotoBindingSource.Position = 0;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            this.productPhotoBindingSource.Position -= 1;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            this.productPhotoBindingSource.Position += 1;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            this.productPhotoBindingSource.Position = this.productPhotoBindingSource.Count - 1;
        }
        private void productPhotoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            label4.Text = $"{this.productPhotoBindingSource.Position + 1}/{this.productPhotoBindingSource.Count}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productPhotoDataGridView.Sort(productPhotoDataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);//datagridview sort by column
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productPhotoTableAdapter.FillByDatePicker(awDataSet.ProductPhoto, dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void FrmAdventureWorks_Load(object sender, EventArgs e)
        {

        }
    }
}
