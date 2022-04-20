
namespace MyHW
{
    partial class FrmMyAlbum
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMyAlbum));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInpuCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCityID = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.相簿 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.相片管理 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.相簿.SuspendLayout();
            this.相片管理.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 519);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlbum.Image")));
            this.pictureBoxAlbum.InitialImage = null;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(6, 4);
            this.pictureBoxAlbum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(229, 241);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 5;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreate.Location = new System.Drawing.Point(42, 39);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(111, 28);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "加入回憶";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(110, 90);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "記憶不再";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(6, 90);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 28);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "更新記憶";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(6, 253);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(232, 29);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "單一檔案上傳";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(0, 24);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(44, 15);
            this.lblCountry.TabIndex = 12;
            this.lblCountry.Text = "國家:";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(0, 42);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(200, 23);
            this.comboBoxCountry.TabIndex = 13;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(0, 86);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(200, 23);
            this.comboBoxCity.TabIndex = 14;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "城市:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "城市(自行輸入)";
            // 
            // txtInpuCity
            // 
            this.txtInpuCity.Location = new System.Drawing.Point(0, 130);
            this.txtInpuCity.Name = "txtInpuCity";
            this.txtInpuCity.Size = new System.Drawing.Size(200, 23);
            this.txtInpuCity.TabIndex = 17;
            this.txtInpuCity.TextChanged += new System.EventHandler(this.txtInpuCity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "日期:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "備註:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(0, 276);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(200, 23);
            this.txtRemarks.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(3, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(226, 28);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search......";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "城市ID:";
            // 
            // lblCityID
            // 
            this.lblCityID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCityID.Location = new System.Drawing.Point(0, 180);
            this.lblCityID.Name = "lblCityID";
            this.lblCityID.Size = new System.Drawing.Size(200, 22);
            this.lblCityID.TabIndex = 23;
            this.lblCityID.Text = "城市ID:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.相簿);
            this.tabControl1.Controls.Add(this.相片管理);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 513);
            this.tabControl1.TabIndex = 25;
            // 
            // 相簿
            // 
            this.相簿.Controls.Add(this.flowLayoutPanel1);
            this.相簿.Controls.Add(this.panel1);
            this.相簿.Location = new System.Drawing.Point(4, 24);
            this.相簿.Name = "相簿";
            this.相簿.Padding = new System.Windows.Forms.Padding(3);
            this.相簿.Size = new System.Drawing.Size(796, 485);
            this.相簿.TabIndex = 0;
            this.相簿.Text = "相簿";
            this.相簿.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(141, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(671, 519);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // 相片管理
            // 
            this.相片管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.相片管理.Controls.Add(this.groupBox4);
            this.相片管理.Controls.Add(this.groupBox3);
            this.相片管理.Controls.Add(this.groupBox2);
            this.相片管理.Controls.Add(this.groupBox1);
            this.相片管理.Controls.Add(this.button2);
            this.相片管理.Controls.Add(this.btnFolder);
            this.相片管理.Controls.Add(this.flowLayoutPanel2);
            this.相片管理.Controls.Add(this.pictureBoxAlbum);
            this.相片管理.Controls.Add(this.btnBrowse);
            this.相片管理.Location = new System.Drawing.Point(4, 24);
            this.相片管理.Name = "相片管理";
            this.相片管理.Padding = new System.Windows.Forms.Padding(3);
            this.相片管理.Size = new System.Drawing.Size(796, 485);
            this.相片管理.TabIndex = 1;
            this.相片管理.Text = "相片管理";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.lblCountry);
            this.groupBox4.Controls.Add(this.comboBoxCity);
            this.groupBox4.Controls.Add(this.comboBoxCountry);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtInpuCity);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lblCityID);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtRemarks);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Location = new System.Drawing.Point(241, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 310);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnSaveAll);
            this.groupBox3.Location = new System.Drawing.Point(451, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 96);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "整批回憶儲存";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 29);
            this.button3.TabIndex = 30;
            this.button3.Text = "資料夾上傳";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 29);
            this.button1.TabIndex = 29;
            this.button1.Text = "多筆檔案上傳";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveAll.Location = new System.Drawing.Point(3, 64);
            this.btnSaveAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(343, 29);
            this.btnSaveAll.TabIndex = 31;
            this.btnSaveAll.Text = "整筆加入回憶";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(244, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 142);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "回憶在資料庫";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 78);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "編輯回憶";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 26);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "城市:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(741, 567);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 29);
            this.button2.TabIndex = 28;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(595, 567);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(123, 29);
            this.btnFolder.TabIndex = 26;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(447, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(349, 380);
            this.flowLayoutPanel2.TabIndex = 25;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // FrmMyAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(804, 513);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMyAlbum";
            this.Text = "FrmTravelPicture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.相簿.ResumeLayout(false);
            this.相片管理.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
                private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInpuCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCityID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 相簿;
        private System.Windows.Forms.TabPage 相片管理;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}