
namespace NadraManagementGUI
{
    partial class frmSehatApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSehatApp));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicantRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citizenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIVID19CertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortedCitizenWithAgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicalStatisticsOfCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citizenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citizenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.userLoginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewComplaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSide = new System.Windows.Forms.Label();
            this.dataGridViewSahat = new System.Windows.Forms.DataGridView();
            this.Accept = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Inspect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Reject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSahat)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.18367F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.searchToolStripMenuItem1,
            this.applicationSectionToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.complaintsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 86);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 61);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.recordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.recordToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(64, 57);
            this.recordToolStripMenuItem.Text = "Home";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicantRecordToolStripMenuItem,
            this.userLoginToolStripMenuItem});
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(50, 57);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // applicantRecordToolStripMenuItem
            // 
            this.applicantRecordToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("applicantRecordToolStripMenuItem.BackgroundImage")));
            this.applicantRecordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.applicantRecordToolStripMenuItem.Name = "applicantRecordToolStripMenuItem";
            this.applicantRecordToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.applicantRecordToolStripMenuItem.Text = "Citizen ";
            this.applicantRecordToolStripMenuItem.Click += new System.EventHandler(this.applicantRecordToolStripMenuItem_Click);
            // 
            // userLoginToolStripMenuItem
            // 
            this.userLoginToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userLoginToolStripMenuItem.BackgroundImage")));
            this.userLoginToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLoginToolStripMenuItem.Name = "userLoginToolStripMenuItem";
            this.userLoginToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.userLoginToolStripMenuItem.Text = "User Login";
            this.userLoginToolStripMenuItem.Click += new System.EventHandler(this.userLoginToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citizenToolStripMenuItem,
            this.userToolStripMenuItem,
            this.cIVID19CertificateToolStripMenuItem,
            this.invoiceToolStripMenuItem});
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(66, 57);
            this.deleteToolStripMenuItem.Text = "Generate";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // citizenToolStripMenuItem
            // 
            this.citizenToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("citizenToolStripMenuItem.BackgroundImage")));
            this.citizenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.citizenToolStripMenuItem.Name = "citizenToolStripMenuItem";
            this.citizenToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.citizenToolStripMenuItem.Text = "Token Number";
            this.citizenToolStripMenuItem.Click += new System.EventHandler(this.citizenToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.BackgroundImage")));
            this.userToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.userToolStripMenuItem.Text = "Identity Card";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // cIVID19CertificateToolStripMenuItem
            // 
            this.cIVID19CertificateToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cIVID19CertificateToolStripMenuItem.BackgroundImage")));
            this.cIVID19CertificateToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cIVID19CertificateToolStripMenuItem.Name = "cIVID19CertificateToolStripMenuItem";
            this.cIVID19CertificateToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cIVID19CertificateToolStripMenuItem.Text = "CIVID-19 Certificate";
            this.cIVID19CertificateToolStripMenuItem.Click += new System.EventHandler(this.cIVID19CertificateToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invoiceToolStripMenuItem.BackgroundImage")));
            this.invoiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortedCitizenWithAgeToolStripMenuItem,
            this.graphicalStatisticsOfCityToolStripMenuItem});
            this.searchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(44, 57);
            this.searchToolStripMenuItem.Text = "View";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // sortedCitizenWithAgeToolStripMenuItem
            // 
            this.sortedCitizenWithAgeToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortedCitizenWithAgeToolStripMenuItem.BackgroundImage")));
            this.sortedCitizenWithAgeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sortedCitizenWithAgeToolStripMenuItem.Name = "sortedCitizenWithAgeToolStripMenuItem";
            this.sortedCitizenWithAgeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.sortedCitizenWithAgeToolStripMenuItem.Text = "Sorted Citizen with Age";
            this.sortedCitizenWithAgeToolStripMenuItem.Click += new System.EventHandler(this.sortedCitizenWithAgeToolStripMenuItem_Click);
            // 
            // graphicalStatisticsOfCityToolStripMenuItem
            // 
            this.graphicalStatisticsOfCityToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphicalStatisticsOfCityToolStripMenuItem.BackgroundImage")));
            this.graphicalStatisticsOfCityToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphicalStatisticsOfCityToolStripMenuItem.Name = "graphicalStatisticsOfCityToolStripMenuItem";
            this.graphicalStatisticsOfCityToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.graphicalStatisticsOfCityToolStripMenuItem.Text = "Graphical Statistics of City";
            this.graphicalStatisticsOfCityToolStripMenuItem.Click += new System.EventHandler(this.graphicalStatisticsOfCityToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citizenToolStripMenuItem1});
            this.searchToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(54, 57);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // citizenToolStripMenuItem1
            // 
            this.citizenToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("citizenToolStripMenuItem1.BackgroundImage")));
            this.citizenToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.citizenToolStripMenuItem1.Name = "citizenToolStripMenuItem1";
            this.citizenToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.citizenToolStripMenuItem1.Text = "Citizen";
            this.citizenToolStripMenuItem1.Click += new System.EventHandler(this.citizenToolStripMenuItem1_Click);
            // 
            // applicationSectionToolStripMenuItem
            // 
            this.applicationSectionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.applicationSectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healthCardToolStripMenuItem});
            this.applicationSectionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.applicationSectionToolStripMenuItem.Name = "applicationSectionToolStripMenuItem";
            this.applicationSectionToolStripMenuItem.Size = new System.Drawing.Size(122, 57);
            this.applicationSectionToolStripMenuItem.Text = "Application Section";
            this.applicationSectionToolStripMenuItem.Click += new System.EventHandler(this.applicationSectionToolStripMenuItem_Click);
            // 
            // healthCardToolStripMenuItem
            // 
            this.healthCardToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("healthCardToolStripMenuItem.BackgroundImage")));
            this.healthCardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.healthCardToolStripMenuItem.Name = "healthCardToolStripMenuItem";
            this.healthCardToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.healthCardToolStripMenuItem.Text = "Health Card ";
            this.healthCardToolStripMenuItem.Click += new System.EventHandler(this.healthCardToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.deleteToolStripMenuItem1.Checked = true;
            this.deleteToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citizenToolStripMenuItem2,
            this.userLoginToolStripMenuItem1});
            this.deleteToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(52, 57);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // citizenToolStripMenuItem2
            // 
            this.citizenToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("citizenToolStripMenuItem2.BackgroundImage")));
            this.citizenToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.citizenToolStripMenuItem2.Name = "citizenToolStripMenuItem2";
            this.citizenToolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.citizenToolStripMenuItem2.Text = "Citizen";
            this.citizenToolStripMenuItem2.Click += new System.EventHandler(this.citizenToolStripMenuItem2_Click);
            // 
            // userLoginToolStripMenuItem1
            // 
            this.userLoginToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userLoginToolStripMenuItem1.BackgroundImage")));
            this.userLoginToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLoginToolStripMenuItem1.Name = "userLoginToolStripMenuItem1";
            this.userLoginToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.userLoginToolStripMenuItem1.Text = "User Login";
            this.userLoginToolStripMenuItem1.Click += new System.EventHandler(this.userLoginToolStripMenuItem1_Click);
            // 
            // complaintsToolStripMenuItem
            // 
            this.complaintsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.complaintsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewComplaintsToolStripMenuItem});
            this.complaintsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.complaintsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.complaintsToolStripMenuItem.Name = "complaintsToolStripMenuItem";
            this.complaintsToolStripMenuItem.Size = new System.Drawing.Size(80, 57);
            this.complaintsToolStripMenuItem.Text = "Complaints";
            this.complaintsToolStripMenuItem.Click += new System.EventHandler(this.complaintsToolStripMenuItem_Click);
            // 
            // viewComplaintsToolStripMenuItem
            // 
            this.viewComplaintsToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewComplaintsToolStripMenuItem.BackgroundImage")));
            this.viewComplaintsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewComplaintsToolStripMenuItem.Name = "viewComplaintsToolStripMenuItem";
            this.viewComplaintsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.viewComplaintsToolStripMenuItem.Text = "View Complaints";
            this.viewComplaintsToolStripMenuItem.Click += new System.EventHandler(this.viewComplaintsToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.375F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.375F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox18, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 80);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(3, 4);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(219, 64);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 1;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Click += new System.EventHandler(this.pictureBox18_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(594, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(193, 64);
            this.flowLayoutPanel2.TabIndex = 4;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "\r\n\r\n09:00-17:00\r\nMonday-Friday\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox17);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(370, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(215, 64);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(3, 29);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(39, 28);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 5;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox17_Click);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 60);
            this.label12.TabIndex = 6;
            this.label12.Text = "\r\n\r\nNADRA Headquarters,\r\nIslamabad, Pakistan";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tableLayoutPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel3.BackgroundImage")));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Controls.Add(this.lblSide, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 147);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(140, 303);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.BackColor = System.Drawing.Color.Transparent;
            this.lblSide.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide.ForeColor = System.Drawing.Color.Lavender;
            this.lblSide.Location = new System.Drawing.Point(7, 61);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(121, 75);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = " Health\r\n Card Application ";
            this.lblSide.Click += new System.EventHandler(this.lblSide_Click);
            // 
            // dataGridViewSahat
            // 
            this.dataGridViewSahat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSahat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accept,
            this.Inspect,
            this.Reject});
            this.dataGridViewSahat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSahat.Location = new System.Drawing.Point(140, 147);
            this.dataGridViewSahat.Name = "dataGridViewSahat";
            this.dataGridViewSahat.Size = new System.Drawing.Size(660, 303);
            this.dataGridViewSahat.TabIndex = 2;
            this.dataGridViewSahat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Accept
            // 
            this.Accept.HeaderText = "Accept";
            this.Accept.Name = "Accept";
            this.Accept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Accept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Accept.Text = "Accept";
            this.Accept.ToolTipText = "Accept";
            this.Accept.UseColumnTextForButtonValue = true;
            // 
            // Inspect
            // 
            this.Inspect.HeaderText = "Inspect";
            this.Inspect.Name = "Inspect";
            this.Inspect.Text = "Inspect";
            this.Inspect.ToolTipText = "Inspect";
            this.Inspect.UseColumnTextForButtonValue = true;
            // 
            // Reject
            // 
            this.Reject.HeaderText = "Reject";
            this.Reject.Name = "Reject";
            this.Reject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Reject.Text = "Reject";
            this.Reject.ToolTipText = "Reject";
            this.Reject.UseColumnTextForButtonValue = true;
            // 
            // frmSehatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSahat);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSehatApp";
            this.Text = "frmSehatApp";
            this.Load += new System.EventHandler(this.frmSehatApp_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSahat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicantRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citizenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIVID19CertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortedCitizenWithAgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicalStatisticsOfCityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citizenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applicationSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citizenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem userLoginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem complaintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewComplaintsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.DataGridView dataGridViewSahat;
        private System.Windows.Forms.DataGridViewButtonColumn Accept;
        private System.Windows.Forms.DataGridViewButtonColumn Inspect;
        private System.Windows.Forms.DataGridViewButtonColumn Reject;
    }
}