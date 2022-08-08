using NadraManagementGUI.BL;
using NadraManagementGUI.DL;
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
    public partial class frmApplicantComplaint : frmApplicant
    {
        public frmApplicantComplaint()
        {
            InitializeComponent();
        }

        private void frmApplicantComplaint_Load(object sender, EventArgs e)
        {

        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sortedCitizenWithAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void graphicalStatisticsOfCityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void citizenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void citizenToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void userLoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            Complaint c = new Complaint(txtEmail.Text,txtUserName.Text, txtComplaint.Text);
            ComplaintCRUD.addIntoList(c);
            ComplaintCRUD.storeDataIntoFile(FilePath.complaintpath);
            txtUserName.Text = "";
            txtEmail.Text = "";
            txtComplaint.Text="";

        }
    }
}
