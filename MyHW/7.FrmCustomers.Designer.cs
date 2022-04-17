﻿
namespace MyHW
{
    partial class FrmCustomers
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
            this.lsVCustomers = new System.Windows.Forms.ListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersIDASCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersIDDESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCountry7 = new System.Windows.Forms.Label();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsVCustomers
            // 
            this.lsVCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsVCustomers.ContextMenuStrip = this.contextMenuStrip;
            this.lsVCustomers.GridLines = true;
            this.lsVCustomers.HideSelection = false;
            this.lsVCustomers.Location = new System.Drawing.Point(3, 297);
            this.lsVCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsVCustomers.Name = "lsVCustomers";
            this.lsVCustomers.Size = new System.Drawing.Size(923, 252);
            this.lsVCustomers.TabIndex = 0;
            this.lsVCustomers.UseCompatibleStateImageBehavior = false;
            this.lsVCustomers.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsViewToolStripMenuItem,
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.orderByToolStripMenuItem,
            this.groupByToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(143, 114);
            // 
            // detailsViewToolStripMenuItem
            // 
            this.detailsViewToolStripMenuItem.Name = "detailsViewToolStripMenuItem";
            this.detailsViewToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.detailsViewToolStripMenuItem.Text = "Details View";
            this.detailsViewToolStripMenuItem.Click += new System.EventHandler(this.detailsViewToolStripMenuItem_Click);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.largeIconToolStripMenuItem.Text = "Large icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.smallIconToolStripMenuItem.Text = "Small icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // orderByToolStripMenuItem
            // 
            this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersIDASCToolStripMenuItem,
            this.customersIDDESCToolStripMenuItem});
            this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
            this.orderByToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.orderByToolStripMenuItem.Text = "Order by";
            this.orderByToolStripMenuItem.Click += new System.EventHandler(this.orderByToolStripMenuItem_Click);
            // 
            // customersIDASCToolStripMenuItem
            // 
            this.customersIDASCToolStripMenuItem.Name = "customersIDASCToolStripMenuItem";
            this.customersIDASCToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.customersIDASCToolStripMenuItem.Text = "Customers ID ASC";
            this.customersIDASCToolStripMenuItem.Click += new System.EventHandler(this.customersIDASCToolStripMenuItem_Click);
            // 
            // customersIDDESCToolStripMenuItem
            // 
            this.customersIDDESCToolStripMenuItem.Name = "customersIDDESCToolStripMenuItem";
            this.customersIDDESCToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.customersIDDESCToolStripMenuItem.Text = "Customers ID DESC";
            this.customersIDDESCToolStripMenuItem.Click += new System.EventHandler(this.customersIDDESCToolStripMenuItem_Click);
            // 
            // groupByToolStripMenuItem
            // 
            this.groupByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem,
            this.cityToolStripMenuItem});
            this.groupByToolStripMenuItem.Name = "groupByToolStripMenuItem";
            this.groupByToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupByToolStripMenuItem.Text = "Group by";
            this.groupByToolStripMenuItem.Click += new System.EventHandler(this.groupByToolStripMenuItem_Click);
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.countryToolStripMenuItem.Text = "Country";
            this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
            // 
            // lblCountry7
            // 
            this.lblCountry7.AutoSize = true;
            this.lblCountry7.Location = new System.Drawing.Point(13, 27);
            this.lblCountry7.Name = "lblCountry7";
            this.lblCountry7.Size = new System.Drawing.Size(56, 15);
            this.lblCountry7.TabIndex = 1;
            this.lblCountry7.Text = "Country";
            // 
            // cbbCountry
            // 
            this.cbbCountry.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.ItemHeight = 15;
            this.cbbCountry.Location = new System.Drawing.Point(103, 24);
            this.cbbCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(136, 23);
            this.cbbCountry.TabIndex = 2;
            this.cbbCountry.SelectedIndexChanged += new System.EventHandler(this.cbbCountry_SelectedIndexChanged);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cityToolStripMenuItem.Text = "City";
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.cbbCountry);
            this.Controls.Add(this.lblCountry7);
            this.Controls.Add(this.lsVCustomers);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCustomers";
            this.Text = "FrmCustomers";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsVCustomers;
        private System.Windows.Forms.Label lblCountry7;
        private System.Windows.Forms.ComboBox cbbCountry;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem detailsViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersIDASCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersIDDESCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
    }
}