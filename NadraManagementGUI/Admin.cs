using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadraManagementGUI
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void applicationSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin form = new Admin();
            form.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void applicantRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCitizen form = new frmAddCitizen();
            form.Show();
            this.Hide();
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser form = new frmAddUser();
            
            form.Show();
        }

        private void sortedCitizenWithAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSortedCitizen form = new frmSortedCitizen();
            this.Hide();
            form.Show();


        }

        private void graphicalStatisticsOfCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraphicalStat form = new frmGraphicalStat();
            form.Show();
            this.Hide();
        }

        private void citizenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSearchCitizen form = new frmSearchCitizen();
            form.Show();
            this.Hide();
        }

        private void healthCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSehatApp form = new frmSehatApp();
            form.Show();
            this.Hide();
        }

        private void citizenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDelete form = new frmDelete();
            form.Show();
            this.Hide();
        }

        private void userLoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDeleteAccount form = new frmDeleteAccount();
            form.Show();
            this.Hide();
        }

        private void citizenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTokenNo form = new frmTokenNo();
            form.Show();
            this.Hide();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCnic form = new frmCnic();
            form.Show();
            this.Hide();
        }

        private void cIVID19CertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCovid form = new frmCovid();
            form.Show();
            this.Hide();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice form = new frmInvoice();
            form.Show();
            this.Hide();

        }

        private void viewComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComplaint form = new frmComplaint();
            form.Show();
            this.Hide();

        }
    }
}
