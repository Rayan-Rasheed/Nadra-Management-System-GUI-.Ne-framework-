
namespace NadraManagementGUI
{
    partial class frmSortedCitizen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSortedCitizen));
            this.dataGridViewSorted = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorted)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSorted
            // 
            this.dataGridViewSorted.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewSorted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSorted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSorted.Location = new System.Drawing.Point(0, 147);
            this.dataGridViewSorted.Name = "dataGridViewSorted";
            this.dataGridViewSorted.Size = new System.Drawing.Size(800, 303);
            this.dataGridViewSorted.TabIndex = 13;
            this.dataGridViewSorted.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSorted_CellContentClick_1);
            // 
            // frmSortedCitizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSorted);
            this.Name = "frmSortedCitizen";
            this.Text = "frmSortedCitizen";
            this.Load += new System.EventHandler(this.frmSortedCitizen_Load);
            this.Controls.SetChildIndex(this.dataGridViewSorted, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSorted;
    }
}