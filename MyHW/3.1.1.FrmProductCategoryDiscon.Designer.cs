
namespace MyHW
{
    partial class FrmProductCategoryDiscon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDisconnected = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDisconnected = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDisconnected
            // 
            this.lbDisconnected.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisconnected.FormattingEnabled = true;
            this.lbDisconnected.ItemHeight = 23;
            this.lbDisconnected.Location = new System.Drawing.Point(229, 112);
            this.lbDisconnected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbDisconnected.Name = "lbDisconnected";
            this.lbDisconnected.Size = new System.Drawing.Size(376, 211);
            this.lbDisconnected.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Products:";
            // 
            // cbDisconnected
            // 
            this.cbDisconnected.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDisconnected.FormattingEnabled = true;
            this.cbDisconnected.Items.AddRange(new object[] {
            "aaa",
            "bbb",
            "ccc"});
            this.cbDisconnected.Location = new System.Drawing.Point(229, 55);
            this.cbDisconnected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDisconnected.Name = "cbDisconnected";
            this.cbDisconnected.Size = new System.Drawing.Size(376, 31);
            this.cbDisconnected.TabIndex = 15;
            this.cbDisconnected.SelectedIndexChanged += new System.EventHandler(this.cbDisconnected_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "CategoryName:";
            // 
            // FrmProductCategoryDiscon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.lbDisconnected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDisconnected);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmProductCategoryDiscon";
            this.Text = "FrmProductCategoryDiscon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDisconnected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDisconnected;
        private System.Windows.Forms.Label label5;
    }
}