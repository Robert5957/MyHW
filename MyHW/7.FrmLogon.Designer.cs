
namespace MyHW
{
    partial class FrmLogon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogon));
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.BackgroundImage")));
            this.PictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.Location = new System.Drawing.Point(2, 2);
            this.PictureBoxLogo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(215, 217);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 16;
            this.PictureBoxLogo.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(449, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 27);
            this.label6.TabIndex = 43;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(449, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOk.Location = new System.Drawing.Point(237, 191);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 28);
            this.btnOk.TabIndex = 39;
            this.btnOk.Text = "確定(&O)";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtPWD
            // 
            this.txtPWD.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPWD.Location = new System.Drawing.Point(237, 135);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(208, 23);
            this.txtPWD.TabIndex = 38;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserName.Location = new System.Drawing.Point(237, 52);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(208, 23);
            this.txtUserName.TabIndex = 36;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Lime;
            this.PasswordLabel.Location = new System.Drawing.Point(237, 91);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(208, 27);
            this.PasswordLabel.TabIndex = 37;
            this.PasswordLabel.Text = "密碼(&P)";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserName.ForeColor = System.Drawing.Color.Lime;
            this.lblUserName.Location = new System.Drawing.Point(237, 9);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(208, 27);
            this.lblUserName.TabIndex = 35;
            this.lblUserName.Text = "使用者名稱(&U)";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(349, 191);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 28);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRegister.Location = new System.Drawing.Point(237, 243);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(213, 28);
            this.btnRegister.TabIndex = 45;
            this.btnRegister.Text = "建立帳號(&R)";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FrmLogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 284);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.PictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogon";
            this.Load += new System.EventHandler(this.FrmLogon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBoxLogo;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.TextBox txtPWD;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label lblUserName;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnRegister;
    }
}