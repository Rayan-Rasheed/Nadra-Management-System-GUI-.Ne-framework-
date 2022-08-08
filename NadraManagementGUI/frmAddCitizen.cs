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
    public partial class frmAddCitizen : Form
    {
        public frmAddCitizen()
        {
            InitializeComponent();
        }
        private void frmAddCitizen_Load(object sender, EventArgs e)
        {

        }

        private void lblTempAdress_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void lblCnic_Click(object sender, EventArgs e)
        {

        }

        private void lblFatherName_Click(object sender, EventArgs e)
        {

        }

        private void lblProvince_Click(object sender, EventArgs e)
        {

        }

        private void lblFName_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtFName.Text!=""&& txtLastName.Text != ""&& cboGender.Text != ""&& txtCity.Text != ""&& txtCnic.Text != ""&& txtFatherName.Text != ""&& cboProvince.Text != ""&& txtTempAdress.Text != ""&& txtPermAdress.Text != ""&& cboVaccine.Text != ""&& cboDose.Text != ""&&dateTimePicker1.Text != ""&& txtIncome.Text != ""&& txtTotalWorth.Text != "")
            {
                int year = dateTimePicker1.Value.Year;
                int month = dateTimePicker1.Value.Month;
                int day = dateTimePicker1.Value.Day;
                int Presentyear = DateTime.Now.Year;
                citizen Add = new citizen(txtFName.Text, txtLastName.Text, cboGender.Text, txtCity.Text, txtCnic.Text, txtFatherName.Text, cboProvince.Text, txtTempAdress.Text, txtPermAdress.Text, cboVaccine.Text, int.Parse(cboDose.Text), day, month, year, int.Parse(txtIncome.Text), int.Parse(txtTotalWorth.Text));
                Add.Age = Presentyear - year;
                citizenCRUD.addCitizenIntoList(Add);
                citizenCRUD.storeDataIntoFile(FilePath.dataPath);
                Admin a = new Admin();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Make sure all field should be filled!");
            }
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser form = new frmAddUser();
            form.Show();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sortedCitizenWithAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSortedCitizen form = new frmSortedCitizen();
            this.Hide();
            form.Show();
        }

        private void citizenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSearchCitizen form = new frmSearchCitizen();
            form.Show();
            this.Hide();
        }

        private void graphicalStatisticsOfCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraphicalStat form = new frmGraphicalStat();
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

        private void viewComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewComplaint form = new frmViewComplaint();
            form.Show();
            this.Hide();

        }

        private void replyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void healthCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSehatApp form = new frmSehatApp();
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

        private void applicantRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCitizen form = new frmAddCitizen();
            form.Show();
            this.Hide();
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin form = new Admin();
            form.Show();
            this.Hide();
        }
    }
}
