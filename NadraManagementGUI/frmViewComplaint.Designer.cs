
namespace NadraManagementGUI
{
    partial class frmViewComplaint
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(42, 186);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(140, 18);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From; Nadra.gov.pk";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(45, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 75);
            this.panel1.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(55, 225);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(85, 13);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "No Mail to Show";
            this.lblMail.Click += new System.EventHandler(this.lblMail_Click);
            // 
            // frmViewComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFrom);
            this.Name = "frmViewComplaint";
            this.Text = "frmViewComplaint";
            this.Load += new System.EventHandler(this.frmViewComplaint_Load);
            this.Controls.SetChildIndex(this.lblFrom, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblMail, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMail;
    }
}