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
    public partial class frmApplicant : Form
    {
        public frmApplicant()
        {
            InitializeComponent();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sortedCitizenWithAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmApplicantCovid form = new frmApplicantCovid();
            form.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicantComplaint form = new frmApplicantComplaint();
            form.Show();
            this.Hide();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mnTrackApp_Click(object sender, EventArgs e)
        {
            frmTrackApplication form = new frmTrackApplication();
            form.Show();
            this.Hide();
        }

        private void mnAppSection_Click(object sender, EventArgs e)
        {

        }

        private void healthCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Communication.Person != null)
            {
                frmApplicantHealth form = new frmApplicantHealth();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You cant apply for Helath card becuase of registration issue!");
            }

        }

        private void viewResponceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewComplaint form = new frmViewComplaint();
            form.Show();
            this.Hide();
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicant form = new frmApplicant();
            form.Show();
            this.Close();
        }

        private void frmApplicant_Load(object sender, EventArgs e)
        {
            
        }
    }
}
