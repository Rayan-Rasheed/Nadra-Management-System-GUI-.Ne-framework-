
namespace NadraManagementGUI
{
    partial class frmHealthInspect
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHealthInspect));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFatherFront = new System.Windows.Forms.Label();
            this.lblFather = new System.Windows.Forms.Label();
            this.lblNameFront = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblAdressFront = new System.Windows.Forms.Label();
            this.chartSearchIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.chartSearchAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.lblCnicFront = new System.Windows.Forms.Label();
            this.lblCnic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSearchIncome)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSearchAge)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblCnic, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblFatherFront, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblFather, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblNameFront, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblAdress, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblAdressFront, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblCnicFront, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 81);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.22222F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.77778F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(273, 154);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // lblFatherFront
            // 
            this.lblFatherFront.AutoSize = true;
            this.lblFatherFront.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatherFront.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFatherFront.Location = new System.Drawing.Point(139, 90);
            this.lblFatherFront.Name = "lblFatherFront";
            this.lblFatherFront.Size = new System.Drawing.Size(0, 16);
            this.lblFatherFront.TabIndex = 9;
            // 
            // lblFather
            // 
            this.lblFather.AutoSize = true;
            this.lblFather.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFather.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFather.Location = new System.Drawing.Point(3, 90);
            this.lblFather.Name = "lblFather";
            this.lblFather.Size = new System.Drawing.Size(0, 16);
            this.lblFather.TabIndex = 8;
            // 
            // lblNameFront
            // 
            this.lblNameFront.AutoSize = true;
            this.lblNameFront.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFront.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNameFront.Location = new System.Drawing.Point(139, 47);
            this.lblNameFront.Name = "lblNameFront";
            this.lblNameFront.Size = new System.Drawing.Size(0, 16);
            this.lblNameFront.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(3, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 4;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdress.Location = new System.Drawing.Point(3, 120);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(0, 16);
            this.lblAdress.TabIndex = 6;
            // 
            // lblAdressFront
            // 
            this.lblAdressFront.AutoSize = true;
            this.lblAdressFront.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdressFront.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdressFront.Location = new System.Drawing.Point(139, 120);
            this.lblAdressFront.Name = "lblAdressFront";
            this.lblAdressFront.Size = new System.Drawing.Size(0, 16);
            this.lblAdressFront.TabIndex = 7;
            // 
            // chartSearchIncome
            // 
            this.chartSearchIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.chartSearchIncome.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSearchIncome.Legends.Add(legend1);
            this.chartSearchIncome.Location = new System.Drawing.Point(232, 3);
            this.chartSearchIncome.Name = "chartSearchIncome";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Income";
            this.chartSearchIncome.Series.Add(series1);
            this.chartSearchIncome.Size = new System.Drawing.Size(244, 232);
            this.chartSearchIncome.TabIndex = 9;
            this.chartSearchIncome.Text = "chart2";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel4.Controls.Add(this.chartSearchIncome, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.chartSearchAge, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(302, 69);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(479, 238);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // chartSearchAge
            // 
            this.chartSearchAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea2.Name = "ChartArea1";
            this.chartSearchAge.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSearchAge.Legends.Add(legend2);
            this.chartSearchAge.Location = new System.Drawing.Point(3, 3);
            this.chartSearchAge.Name = "chartSearchAge";
            this.chartSearchAge.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Age";
            series2.YValuesPerPoint = 2;
            this.chartSearchAge.Series.Add(series2);
            this.chartSearchAge.Size = new System.Drawing.Size(223, 232);
            this.chartSearchAge.TabIndex = 3;
            this.chartSearchAge.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 0);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 13;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.MediumTurquoise;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.Color.Gray;
            this.cmdClose.Location = new System.Drawing.Point(742, 3);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(46, 43);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "X";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // lblCnicFront
            // 
            this.lblCnicFront.AutoSize = true;
            this.lblCnicFront.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnicFront.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCnicFront.Location = new System.Drawing.Point(139, 0);
            this.lblCnicFront.Name = "lblCnicFront";
            this.lblCnicFront.Size = new System.Drawing.Size(0, 16);
            this.lblCnicFront.TabIndex = 10;
            // 
            // lblCnic
            // 
            this.lblCnic.AutoSize = true;
            this.lblCnic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCnic.Location = new System.Drawing.Point(3, 0);
            this.lblCnic.Name = "lblCnic";
            this.lblCnic.Size = new System.Drawing.Size(0, 16);
            this.lblCnic.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inspection";
            // 
            // frmHealthInspect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(801, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHealthInspect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHealthInspect";
            this.Load += new System.EventHandler(this.frmHealthInspect_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSearchIncome)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSearchAge)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblFatherFront;
        private System.Windows.Forms.Label lblFather;
        private System.Windows.Forms.Label lblNameFront;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblAdressFront;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSearchIncome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSearchAge;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label lblCnic;
        private System.Windows.Forms.Label lblCnicFront;
        private System.Windows.Forms.Label label1;
    }
}