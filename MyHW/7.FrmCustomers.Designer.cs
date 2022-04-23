
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
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
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblCountry7 = new System.Windows.Forms.Label();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deatilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.companyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactTitleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupByToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alphabetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphabetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsVCustomers
            // 
            this.lsVCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsVCustomers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lsVCustomers.ContextMenuStrip = this.contextMenuStrip;
            this.lsVCustomers.GridLines = true;
            this.lsVCustomers.HideSelection = false;
            this.lsVCustomers.LargeImageList = this.ImageList2;
            this.lsVCustomers.Location = new System.Drawing.Point(3, 106);
            this.lsVCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsVCustomers.Name = "lsVCustomers";
            this.lsVCustomers.Size = new System.Drawing.Size(923, 443);
            this.lsVCustomers.SmallImageList = this.ImageList1;
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
            this.groupByToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.groupByToolStripMenuItem.Text = "Group by";
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.countryToolStripMenuItem.Text = "Country";
            this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cityToolStripMenuItem.Text = "City";
            // 
            // ImageList2
            // 
            this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList2.Images.SetKeyName(0, "FLGGERM.ICO");
            this.ImageList2.Images.SetKeyName(1, "CTRCAN.ICO");
            this.ImageList2.Images.SetKeyName(2, "CTRFRAN.ICO");
            this.ImageList2.Images.SetKeyName(3, "CTRGERM.ICO");
            this.ImageList2.Images.SetKeyName(4, "CTRITALY.ICO");
            this.ImageList2.Images.SetKeyName(5, "CTRJAPAN.ICO");
            this.ImageList2.Images.SetKeyName(6, "CTRMEX.ICO");
            this.ImageList2.Images.SetKeyName(7, "CTRSKOR.ICO");
            this.ImageList2.Images.SetKeyName(8, "CTRSPAIN.ICO");
            this.ImageList2.Images.SetKeyName(9, "CTRUK.ICO");
            this.ImageList2.Images.SetKeyName(10, "CTRUSA.ICO");
            this.ImageList2.Images.SetKeyName(11, "FLGASTRL.ICO");
            this.ImageList2.Images.SetKeyName(12, "FLGAUSTA.ICO");
            this.ImageList2.Images.SetKeyName(13, "FLGBELG.ICO");
            this.ImageList2.Images.SetKeyName(14, "FLGBRAZL.ICO");
            this.ImageList2.Images.SetKeyName(15, "FLGCAN.ICO");
            this.ImageList2.Images.SetKeyName(16, "FLGDEN.ICO");
            this.ImageList2.Images.SetKeyName(17, "FLGFIN.ICO");
            this.ImageList2.Images.SetKeyName(18, "FLGFRAN.ICO");
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "FLGGERM.ICO");
            this.ImageList1.Images.SetKeyName(1, "CTRCAN.ICO");
            this.ImageList1.Images.SetKeyName(2, "CTRFRAN.ICO");
            this.ImageList1.Images.SetKeyName(3, "CTRGERM.ICO");
            this.ImageList1.Images.SetKeyName(4, "CTRITALY.ICO");
            this.ImageList1.Images.SetKeyName(5, "CTRJAPAN.ICO");
            this.ImageList1.Images.SetKeyName(6, "CTRMEX.ICO");
            this.ImageList1.Images.SetKeyName(7, "CTRSKOR.ICO");
            this.ImageList1.Images.SetKeyName(8, "CTRSPAIN.ICO");
            this.ImageList1.Images.SetKeyName(9, "CTRUK.ICO");
            this.ImageList1.Images.SetKeyName(10, "CTRUSA.ICO");
            this.ImageList1.Images.SetKeyName(11, "FLGASTRL.ICO");
            this.ImageList1.Images.SetKeyName(12, "FLGAUSTA.ICO");
            this.ImageList1.Images.SetKeyName(13, "FLGBELG.ICO");
            this.ImageList1.Images.SetKeyName(14, "FLGBRAZL.ICO");
            this.ImageList1.Images.SetKeyName(15, "FLGCAN.ICO");
            this.ImageList1.Images.SetKeyName(16, "FLGDEN.ICO");
            this.ImageList1.Images.SetKeyName(17, "FLGFIN.ICO");
            this.ImageList1.Images.SetKeyName(18, "FLGFRAN.ICO");
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.orderByToolStripMenuItem1,
            this.groupByToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 70);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deatilsToolStripMenuItem,
            this.largeIconToolStripMenuItem1,
            this.smallIconToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // deatilsToolStripMenuItem
            // 
            this.deatilsToolStripMenuItem.Name = "deatilsToolStripMenuItem";
            this.deatilsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.deatilsToolStripMenuItem.Text = "Deatils";
            // 
            // largeIconToolStripMenuItem1
            // 
            this.largeIconToolStripMenuItem1.Name = "largeIconToolStripMenuItem1";
            this.largeIconToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.largeIconToolStripMenuItem1.Text = "LargeIcon";
            // 
            // smallIconToolStripMenuItem1
            // 
            this.smallIconToolStripMenuItem1.Name = "smallIconToolStripMenuItem1";
            this.smallIconToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.smallIconToolStripMenuItem1.Text = "SmallIcon";
            // 
            // orderByToolStripMenuItem1
            // 
            this.orderByToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem2,
            this.cityToolStripMenuItem2,
            this.companyNameToolStripMenuItem,
            this.contactNameToolStripMenuItem,
            this.contactTitleToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.aSCToolStripMenuItem,
            this.dESCToolStripMenuItem});
            this.orderByToolStripMenuItem1.Name = "orderByToolStripMenuItem1";
            this.orderByToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.orderByToolStripMenuItem1.Text = "Order By";
            // 
            // countryToolStripMenuItem2
            // 
            this.countryToolStripMenuItem2.Name = "countryToolStripMenuItem2";
            this.countryToolStripMenuItem2.Size = new System.Drawing.Size(204, 22);
            this.countryToolStripMenuItem2.Text = "Country";
            // 
            // cityToolStripMenuItem2
            // 
            this.cityToolStripMenuItem2.Name = "cityToolStripMenuItem2";
            this.cityToolStripMenuItem2.Size = new System.Drawing.Size(204, 22);
            this.cityToolStripMenuItem2.Text = "City";
            // 
            // companyNameToolStripMenuItem
            // 
            this.companyNameToolStripMenuItem.Name = "companyNameToolStripMenuItem";
            this.companyNameToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.companyNameToolStripMenuItem.Text = "CompanyName";
            // 
            // contactNameToolStripMenuItem
            // 
            this.contactNameToolStripMenuItem.Name = "contactNameToolStripMenuItem";
            this.contactNameToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.contactNameToolStripMenuItem.Text = "ContactName";
            // 
            // contactTitleToolStripMenuItem1
            // 
            this.contactTitleToolStripMenuItem1.Name = "contactTitleToolStripMenuItem1";
            this.contactTitleToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.contactTitleToolStripMenuItem1.Text = "ContactTitle";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem2.Text = "--------------------------";
            // 
            // aSCToolStripMenuItem
            // 
            this.aSCToolStripMenuItem.Name = "aSCToolStripMenuItem";
            this.aSCToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aSCToolStripMenuItem.Text = "ASC";
            // 
            // dESCToolStripMenuItem
            // 
            this.dESCToolStripMenuItem.Name = "dESCToolStripMenuItem";
            this.dESCToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.dESCToolStripMenuItem.Text = "DESC";
            // 
            // groupByToolStripMenuItem1
            // 
            this.groupByToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem1,
            this.cityToolStripMenuItem1,
            this.contactTitleToolStripMenuItem,
            this.alphabetToolStripMenuItem});
            this.groupByToolStripMenuItem1.Name = "groupByToolStripMenuItem1";
            this.groupByToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.groupByToolStripMenuItem1.Text = "Group By";
            // 
            // countryToolStripMenuItem1
            // 
            this.countryToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alphabetToolStripMenuItem1});
            this.countryToolStripMenuItem1.Name = "countryToolStripMenuItem1";
            this.countryToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.countryToolStripMenuItem1.Text = "Country";
            // 
            // alphabetToolStripMenuItem1
            // 
            this.alphabetToolStripMenuItem1.Name = "alphabetToolStripMenuItem1";
            this.alphabetToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.alphabetToolStripMenuItem1.Text = "Alphabet";
            // 
            // cityToolStripMenuItem1
            // 
            this.cityToolStripMenuItem1.Name = "cityToolStripMenuItem1";
            this.cityToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.cityToolStripMenuItem1.Text = "City";
            // 
            // contactTitleToolStripMenuItem
            // 
            this.contactTitleToolStripMenuItem.Name = "contactTitleToolStripMenuItem";
            this.contactTitleToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.contactTitleToolStripMenuItem.Text = "ContactTitle";
            // 
            // alphabetToolStripMenuItem
            // 
            this.alphabetToolStripMenuItem.Name = "alphabetToolStripMenuItem";
            this.alphabetToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.alphabetToolStripMenuItem.Text = "Alphabet";
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
            this.contextMenuStrip1.ResumeLayout(false);
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
        internal System.Windows.Forms.ImageList ImageList2;
        internal System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deatilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem groupByToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contactTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem companyNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactTitleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aSCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphabetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alphabetToolStripMenuItem;
    }
}