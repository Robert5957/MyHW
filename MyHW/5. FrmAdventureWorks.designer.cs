﻿
namespace MyHomeWork
{
    partial class FrmAdventureWorks
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
            System.Windows.Forms.Label productPhotoIDLabel;
            System.Windows.Forms.Label thumbNailPhotoLabel;
            System.Windows.Forms.Label thumbnailPhotoFileNameLabel;
            System.Windows.Forms.Label largePhotoLabel;
            System.Windows.Forms.Label largePhotoFileNameLabel;
            System.Windows.Forms.Label modifiedDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdventureWorks));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.productPhotoIDTextBox = new System.Windows.Forms.TextBox();
            this.productPhotoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.awDataSet = new MyHW.awDataSet();
            this.thumbNailPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.thumbnailPhotoFileNameTextBox = new System.Windows.Forms.TextBox();
            this.largePhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.largePhotoFileNameTextBox = new System.Windows.Forms.TextBox();
            this.modifiedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productPhotoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPhotoTableAdapter = new MyHW.awDataSetTableAdapters.ProductPhotoTableAdapter();
            this.tableAdapterManager = new MyHW.awDataSetTableAdapters.TableAdapterManager();
            productPhotoIDLabel = new System.Windows.Forms.Label();
            thumbNailPhotoLabel = new System.Windows.Forms.Label();
            thumbnailPhotoFileNameLabel = new System.Windows.Forms.Label();
            largePhotoLabel = new System.Windows.Forms.Label();
            largePhotoFileNameLabel = new System.Windows.Forms.Label();
            modifiedDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbNailPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largePhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productPhotoIDLabel
            // 
            productPhotoIDLabel.AutoSize = true;
            productPhotoIDLabel.Location = new System.Drawing.Point(1115, 474);
            productPhotoIDLabel.Name = "productPhotoIDLabel";
            productPhotoIDLabel.Size = new System.Drawing.Size(126, 14);
            productPhotoIDLabel.TabIndex = 85;
            productPhotoIDLabel.Text = "Product Photo ID:";
            // 
            // thumbNailPhotoLabel
            // 
            thumbNailPhotoLabel.AutoSize = true;
            thumbNailPhotoLabel.Location = new System.Drawing.Point(1120, 177);
            thumbNailPhotoLabel.Name = "thumbNailPhotoLabel";
            thumbNailPhotoLabel.Size = new System.Drawing.Size(126, 14);
            thumbNailPhotoLabel.TabIndex = 87;
            thumbNailPhotoLabel.Text = "Thumb Nail Photo:";
            // 
            // thumbnailPhotoFileNameLabel
            // 
            thumbnailPhotoFileNameLabel.AutoSize = true;
            thumbnailPhotoFileNameLabel.Location = new System.Drawing.Point(1115, 404);
            thumbnailPhotoFileNameLabel.Name = "thumbnailPhotoFileNameLabel";
            thumbnailPhotoFileNameLabel.Size = new System.Drawing.Size(189, 14);
            thumbnailPhotoFileNameLabel.TabIndex = 89;
            thumbnailPhotoFileNameLabel.Text = "Thumbnail Photo File Name:";
            // 
            // largePhotoLabel
            // 
            largePhotoLabel.AutoSize = true;
            largePhotoLabel.Location = new System.Drawing.Point(680, 166);
            largePhotoLabel.Name = "largePhotoLabel";
            largePhotoLabel.Size = new System.Drawing.Size(91, 14);
            largePhotoLabel.TabIndex = 91;
            largePhotoLabel.Text = "Large Photo:";
            // 
            // largePhotoFileNameLabel
            // 
            largePhotoFileNameLabel.AutoSize = true;
            largePhotoFileNameLabel.Location = new System.Drawing.Point(667, 593);
            largePhotoFileNameLabel.Name = "largePhotoFileNameLabel";
            largePhotoFileNameLabel.Size = new System.Drawing.Size(161, 14);
            largePhotoFileNameLabel.TabIndex = 93;
            largePhotoFileNameLabel.Text = "Large Photo File Name:";
            // 
            // modifiedDateLabel
            // 
            modifiedDateLabel.AutoSize = true;
            modifiedDateLabel.Location = new System.Drawing.Point(1115, 547);
            modifiedDateLabel.Name = "modifiedDateLabel";
            modifiedDateLabel.Size = new System.Drawing.Size(105, 14);
            modifiedDateLabel.TabIndex = 95;
            modifiedDateLabel.Text = "Modified Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(45, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 14);
            this.label3.TabIndex = 84;
            this.label3.Text = "AWDataSetModel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 82;
            this.label4.Text = "label4";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(304, 107);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(54, 45);
            this.button16.TabIndex = 81;
            this.button16.Text = ">>";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(246, 107);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(54, 45);
            this.button15.TabIndex = 80;
            this.button15.Text = ">";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(107, 107);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(54, 45);
            this.button14.TabIndex = 79;
            this.button14.Text = "<";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(49, 107);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(54, 45);
            this.button13.TabIndex = 78;
            this.button13.Text = "<<";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(723, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 22);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 77;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 76;
            this.label2.Text = "Year:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 27);
            this.button1.TabIndex = 74;
            this.button1.Text = " 某 日期區間 的腳踏車";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 75;
            this.label1.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(206, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker2.TabIndex = 73;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker1.TabIndex = 72;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(35, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 28);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(395, 107);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(262, 31);
            this.bindingNavigator1.TabIndex = 83;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 85;
            this.button2.Text = "排序";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productPhotoIDTextBox
            // 
            this.productPhotoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productPhotoBindingSource, "ProductPhotoID", true));
            this.productPhotoIDTextBox.Location = new System.Drawing.Point(1115, 504);
            this.productPhotoIDTextBox.Name = "productPhotoIDTextBox";
            this.productPhotoIDTextBox.Size = new System.Drawing.Size(233, 22);
            this.productPhotoIDTextBox.TabIndex = 86;
            // 
            // productPhotoBindingSource
            // 
            this.productPhotoBindingSource.DataMember = "ProductPhoto";
            this.productPhotoBindingSource.DataSource = this.awDataSet;
            this.productPhotoBindingSource.CurrentChanged += new System.EventHandler(this.productPhotoBindingSource_CurrentChanged);
            // 
            // awDataSet
            // 
            this.awDataSet.DataSetName = "awDataSet";
            this.awDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thumbNailPhotoPictureBox
            // 
            this.thumbNailPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumbNailPhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productPhotoBindingSource, "ThumbNailPhoto", true));
            this.thumbNailPhotoPictureBox.Location = new System.Drawing.Point(1120, 206);
            this.thumbNailPhotoPictureBox.Name = "thumbNailPhotoPictureBox";
            this.thumbNailPhotoPictureBox.Size = new System.Drawing.Size(217, 185);
            this.thumbNailPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbNailPhotoPictureBox.TabIndex = 88;
            this.thumbNailPhotoPictureBox.TabStop = false;
            // 
            // thumbnailPhotoFileNameTextBox
            // 
            this.thumbnailPhotoFileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productPhotoBindingSource, "ThumbnailPhotoFileName", true));
            this.thumbnailPhotoFileNameTextBox.Location = new System.Drawing.Point(1115, 436);
            this.thumbnailPhotoFileNameTextBox.Name = "thumbnailPhotoFileNameTextBox";
            this.thumbnailPhotoFileNameTextBox.Size = new System.Drawing.Size(233, 22);
            this.thumbnailPhotoFileNameTextBox.TabIndex = 90;
            // 
            // largePhotoPictureBox
            // 
            this.largePhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largePhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productPhotoBindingSource, "LargePhoto", true));
            this.largePhotoPictureBox.Location = new System.Drawing.Point(659, 206);
            this.largePhotoPictureBox.Name = "largePhotoPictureBox";
            this.largePhotoPictureBox.Size = new System.Drawing.Size(424, 384);
            this.largePhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.largePhotoPictureBox.TabIndex = 92;
            this.largePhotoPictureBox.TabStop = false;
            // 
            // largePhotoFileNameTextBox
            // 
            this.largePhotoFileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productPhotoBindingSource, "LargePhotoFileName", true));
            this.largePhotoFileNameTextBox.Location = new System.Drawing.Point(670, 634);
            this.largePhotoFileNameTextBox.Name = "largePhotoFileNameTextBox";
            this.largePhotoFileNameTextBox.Size = new System.Drawing.Size(233, 22);
            this.largePhotoFileNameTextBox.TabIndex = 94;
            // 
            // modifiedDateDateTimePicker
            // 
            this.modifiedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productPhotoBindingSource, "ModifiedDate", true));
            this.modifiedDateDateTimePicker.Location = new System.Drawing.Point(1116, 576);
            this.modifiedDateDateTimePicker.Name = "modifiedDateDateTimePicker";
            this.modifiedDateDateTimePicker.Size = new System.Drawing.Size(233, 22);
            this.modifiedDateDateTimePicker.TabIndex = 96;
            // 
            // productPhotoDataGridView
            // 
            this.productPhotoDataGridView.AutoGenerateColumns = false;
            this.productPhotoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productPhotoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productPhotoDataGridView.DataSource = this.productPhotoBindingSource;
            this.productPhotoDataGridView.Location = new System.Drawing.Point(9, 174);
            this.productPhotoDataGridView.Name = "productPhotoDataGridView";
            this.productPhotoDataGridView.RowTemplate.Height = 24;
            this.productPhotoDataGridView.Size = new System.Drawing.Size(653, 497);
            this.productPhotoDataGridView.TabIndex = 96;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductPhotoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductPhotoID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "ThumbNailPhoto";
            this.dataGridViewImageColumn1.HeaderText = "ThumbNailPhoto";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ThumbnailPhotoFileName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ThumbnailPhotoFileName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "LargePhoto";
            this.dataGridViewImageColumn2.HeaderText = "LargePhoto";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LargePhotoFileName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LargePhotoFileName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ModifiedDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "ModifiedDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // productPhotoTableAdapter
            // 
            this.productPhotoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductPhotoTableAdapter = this.productPhotoTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyHW.awDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmAdventureWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 672);
            this.Controls.Add(this.productPhotoDataGridView);
            this.Controls.Add(productPhotoIDLabel);
            this.Controls.Add(this.productPhotoIDTextBox);
            this.Controls.Add(thumbNailPhotoLabel);
            this.Controls.Add(this.thumbNailPhotoPictureBox);
            this.Controls.Add(thumbnailPhotoFileNameLabel);
            this.Controls.Add(this.thumbnailPhotoFileNameTextBox);
            this.Controls.Add(largePhotoLabel);
            this.Controls.Add(this.largePhotoPictureBox);
            this.Controls.Add(largePhotoFileNameLabel);
            this.Controls.Add(this.largePhotoFileNameTextBox);
            this.Controls.Add(modifiedDateLabel);
            this.Controls.Add(this.modifiedDateDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdventureWorks";
            this.Text = "FrmAdventureWorks";
            this.Load += new System.EventHandler(this.FrmAdventureWorks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbNailPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largePhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.Button button2;
        private MyHW.awDataSet awDataSet;
        private System.Windows.Forms.BindingSource productPhotoBindingSource;
        private MyHW.awDataSetTableAdapters.ProductPhotoTableAdapter productPhotoTableAdapter;
        private MyHW.awDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox productPhotoIDTextBox;
        private System.Windows.Forms.PictureBox thumbNailPhotoPictureBox;
        private System.Windows.Forms.TextBox thumbnailPhotoFileNameTextBox;
        private System.Windows.Forms.PictureBox largePhotoPictureBox;
        private System.Windows.Forms.TextBox largePhotoFileNameTextBox;
        private System.Windows.Forms.DateTimePicker modifiedDateDateTimePicker;
        private System.Windows.Forms.DataGridView productPhotoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}