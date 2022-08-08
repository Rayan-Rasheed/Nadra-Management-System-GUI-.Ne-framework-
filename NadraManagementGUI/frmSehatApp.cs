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
    public partial class frmSehatApp : Form
    {
        public frmSehatApp()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            dataGridViewSahat.DataSource = null;
            dataGridViewSahat.DataSource = citizenCRUD.SahatAppList;
            dataGridViewSahat.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            citizen person = (citizen)dataGridViewSahat.CurrentRow.DataBoundItem;
            if (dataGridViewSahat.Columns["Accept"].Index == e.ColumnIndex)
            {
                //accpting and than delte from sahatapp list and add into selectedSahatList
                citizenCRUD.addSahatSelectedCitizen(person);
                citizenCRUD.deleteUserFromList(person,citizenCRUD.SahatAppList);
                citizenCRUD.StoreIntoFileSahatApp(FilePath.sahatAppPath, FilePath.sahatSelectPath);
                dataBind();

            }
            else if (dataGridViewSahat.Columns["Reject"].Index == e.ColumnIndex)
            {
                //delete application from sahatAppList
                citizenCRUD.deleteUserFromList(person,citizenCRUD.SahatAppList);
                citizenCRUD.StoreIntoFileSahatApp(FilePath.sahatAppPath, FilePath.sahatSelectPath);
                dataBind();
            }
            else if (dataGridViewSahat.Columns["Inspect"].Index == e.ColumnIndex)
            {
                frmHealthInspect form = new frmHealthInspect();
                Communication.Person = person;
                form.Show();


            }
        }

        private void frmSehatApp_Load(object sender, EventArgs e)
        {
            citizenCRUD.sortedDatalist();
            dataGridViewSahat.DataSource = citizenCRUD.SahatAppList;
        }

        private void citizenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSearchCitizen form = new frmSearchCitizen();
            form.Show();
            this.Hide();
        }

        private void sortedCitizenWithAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSortedCitizen form = new frmSortedCitizen();
            form.Show();
            this.Hide();
        }

        private void graphicalStatisticsOfCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraphicalStat form = new frmGraphicalStat();
            form.Show();
            this.Hide();
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
            this.Hide();
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin form = new Admin();
            form.Show();
            this.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void applicationSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void healthCardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

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

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComplaint form = new frmComplaint();
            form.Show();
            this.Hide();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSide_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
